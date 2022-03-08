using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting between pages and the scheduler algorithm 
    public class SchedulerService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;
        /// List of normal LessonVar objects to schedule (HLs 4 lessons and SLs 6 lessons per week) 
        private List<LessonVar> Lessons;
        /// List of special LessonVar objects in multiple Blocks or with a different number of lessons per cycle 
        private List<LessonVar> Specials;
        /// List of Groups to assign LessonVars to and to assign to Periods 
        private List<Group> Groups;

        /// Sets the database context (needed for dependency injection) 
        public SchedulerService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Prepares the Lessons, Specials, and Groups lists. Then solves for
        /// a timetable and converts the solution into LessonVar objects 
        public List<LessonVar> GenerateTimetable() {
            SplitLessons();
            AssignToGroups();
            // Creates a new scheduler object from Models 
            Scheduler scheduler = new Scheduler();
            // If the scheduler is able to generate a timetable, convert it into LessonVar objects  
            if (scheduler.Schedule(Groups)) {
                Lessons = SolutionToLessons(scheduler.Solution, Groups, Specials);
            }
            // Otherwise, clear the Lessons list 
            else {
                Lessons.Clear();
            }
            return Lessons;
        }
        
        /// Populates the Lessons and Specials lists 
        private async void SplitLessons() {
            // Uses _ibTimetablerContext to directly access all Lessons in database 
            Lessons = await _ibTimetablerContext.Lessons.Select(x=>new LessonVar(x)).ToListAsync();
            // HashSet objects only store unique values (do not allow for duplicates) 
            HashSet<long> hashSet = new HashSet<long>();
            // If an Id appears more than once in LessonIdblockIds (it is in multiple blocks), add it to duplicates 
            var duplicates = _ibTimetablerContext.LessonIdblockIds.ToList()
                .Where(x => !hashSet.Add(x.LessonId)).Select(x=>x.LessonId).Distinct().ToList();
            // List of non-normal LessonVar objects to schedule (not HLs 4 lessons, not SLs 6 lessons per week, or is in duplicates) 
            Specials = Lessons.Where(x=> (x.NumLessons != 4 && x.Level == "HL") || (x.NumLessons != 6 && x.Level == "SL")
                || duplicates.Contains(x.Id)).ToList();
        }

        /// Assigns LessonVar objects to their respective Groups (based on Block and level) 
        private void AssignToGroups() {
            Groups = new List<Group>();
            // Directly accesses all Periods in week A in database and converts them into PeriodVars in array 
            PeriodVar[] periods = _ibTimetablerContext.Periods.Where(x=>x.Week == 0)
                .Select(x=>new PeriodVar(x)).ToArray();
            // Create a Group for both levels in each block 
            foreach (Block b in _ibTimetablerContext.Blocks) {
                for (int i = 0; i < 2; i++) {
                    Groups.Add(new Group {Level = i == 0 ? "HL" : "SL",
                        Block = b.Id, NumLessons = i == 0 ? 2 : 3,
                        Periods = (PeriodVar[]) periods.Clone(), Year = 12});
                    Groups.Add(new Group {Level = i == 0 ? "HL" : "SL",
                        Block = b.Id, NumLessons = i == 0 ? 2 : 3,
                        Periods = (PeriodVar[]) periods.Clone(), Year = 13});
                }
            }
            // Assign LessonVars to each Group 
            for (int g = 0; g < Groups.Count; g++) {
                Group group = Groups[g];
                group.Classes = new List<LessonVar>();
                // Loop through each Lesson with the same Block as the current Group 
                foreach (var lessonIdblockId in _ibTimetablerContext.LessonIdblockIds
                             .Where(x=>x.BlockId == group.Block)) {
                    // Find the corresponding LessonVar for the Lesson in the Block 
                    LessonVar l = Lessons.Find(x => x.Id == lessonIdblockId.LessonId);
                    // If the LessonVar object is of the same year and level as the Group, add it to the Group 
                    if (l?.Level == group.Level && l?.Year == group.Year) group.Classes.Add(l);
                    // Otherwise, if it is in Specials and for the same year, add it to the Group 
                    else if (Specials.Contains(l) && l?.Year == group.Year) {
                        group.Classes.Add(l);
                    }
                }
                // If the current Group has LessonVar objects, continue to next Group 
                if (group.Classes.Count != 0) continue;
                // Otherwise, delete the current Group and subtract 1 from g to ensure no Groups r skipped 
                Groups.RemoveAt(g);
                g--;
            }
        }

        /// Converts the solution from a list of strings into a list of LessonVar objects 
        private List<LessonVar> SolutionToLessons(List<string> solution, List<Group> groups, List<LessonVar> specials) {
            Random r = new Random();
            List<LessonVar> lessons = new List<LessonVar>();
            // Retrieve all RoomIdlessonIds from database 
            var roomIdlessonIds = _ibTimetablerContext.RoomIdlessonIds.ToList();
            // Loop through each group and collect their assigned PeriodVars 
            foreach (Group g in groups) {
                // List of all room Ids 
                var rooms = _ibTimetablerContext.Rooms.Select(x=>x.Id).ToList();
                // List of indexes in domain of current Group that correspond to the PeriodVars it is scheduled for. 
                // Found from all entries of the exact Group (same year, block, and level) in solution 
                List<int> indexes = solution.FindAll(x => int.Parse(x.Split(',')[0].ToString()) == g.Year 
                    && int.Parse(x.Split(',')[1].ToString()) == g.Block &&
                    x.Split(',')[2].ToString() == g.Level)
                    .Select(x => int.Parse(x.Split(',')[3])).ToList();
                List<PeriodVar> periods = new List<PeriodVar>();
                // Add scheduled periods for Group into periods list 
                foreach (int index in indexes) {
                    periods.Add(g.Periods[index]);
                }
                periods = periods.OrderBy(x => x.Week).ThenBy(x=>x.Day)
                    .ThenBy(x=>x.TimePeriod).ToList();
                // Loop through all LessonVars in the Group 
                foreach (LessonVar l in g.Classes) {
                    int found = lessons.FindIndex(x => x.Id == l.Id);
                    // If the LessonVar was already added to lessons 
                    if (found != -1) {
                        // Add the scheduled PeriodVars from the Group to the LessonVar and continue to the next LessonVar 
                        lessons[found].Periods = lessons[found].Periods.Concat(periods).ToList();
                        continue;
                    }
                    long roomId;
                    try {
                        // Try to assign the SavedLesson a random permitted room 
                        roomId = roomIdlessonIds.Where(x => x.LessonId == l.Id)
                            .Select(x => x.RoomId)
                            .OrderBy(x => r.Next()).First(x => rooms.Contains(x));
                    }
                    // If there are no RoomIdlessonIds, return 0 to show no room was assigned 
                    catch (InvalidOperationException) {
                        roomId = 0;
                    }
                    LessonVar lesson = new LessonVar (l.Id, l.Name, l.Year, l.Level, l.ClassCode,
                        l.NumLessons, l.TeacherId, new List<PeriodVar>(periods), roomId);
                    lessons.Add(lesson);
                }
            }
            // Mirror timetable over to week B and schedule exact required amount for LessonVars in Specials 
            foreach (LessonVar l in lessons) {
                // If LessonVar in Specials, take the (greater) half of the required Periods for the LessonVar and 
                // re-order their scheduled PeriodVars to prioritize earlier Periods (not Period 7) 
                if (specials.FindIndex(x=>x.Id == l.Id) != -1) 
                    l.Periods = l.Periods.OrderBy(x=>r.Next()).Take((int)Math.Ceiling((double) l.NumLessons / (double) 2)
                    ).OrderBy(x=>x.Week).ThenBy(x=>x.Day).ThenBy(x=>x.TimePeriod).ToList();
                int length = l.Periods.Count;
                // Copy over to week B whichever is least, the Periods scheduled in week A,
                // or (lower) half of the required NumLessons to be scheduled 
                for (int period = 0; period < (length < l.NumLessons / 2 ? length : l.NumLessons / 2); period++) {
                    PeriodVar p = l.Periods[period];
                    l.Periods.Add(new PeriodVar(_ibTimetablerContext.Periods.ToList().Find(
                        x=>x.Week == 1 && x.Day == p.Day && x.TimePeriod == p.TimePeriod)));
                }
            }
            return lessons;
        }
    }
}