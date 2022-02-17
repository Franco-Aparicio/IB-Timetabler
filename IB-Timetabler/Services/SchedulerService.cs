using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class SchedulerService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;
        private List<LessonVar> Lessons;
        private List<LessonVar> Specials;
        private List<Group> Groups;

        public SchedulerService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public List<LessonVar> GenerateTimetable() {
            SplitLessons();
            AssignToGroups();
            Scheduler scheduler = new Scheduler();
            if (scheduler.Schedule(Groups)) {
                Lessons = SolutionToLessons(scheduler.Solution, Groups, Specials);
            }
            else {
                Lessons.Clear();
            }
            return Lessons;
        }
        
        private async void SplitLessons() {
            Lessons = await _ibTimetablerContext.Lessons.Select(x=>new LessonVar(x)).ToListAsync();
            HashSet<long> hashSet = new HashSet<long>();
            var duplicates = _ibTimetablerContext.LessonIdblockIds.ToList()
                .Where(x => !hashSet.Add(x.LessonId)).Select(x=>x.LessonId).Distinct().ToList();
            Specials = Lessons.Where(x=> (x.NumLessons != 4 && x.Level == "HL") || (x.NumLessons != 6 && x.Level == "SL")
                || duplicates.Contains(x.Id)).ToList();
        }

        private void AssignToGroups() {
            Groups = new List<Group>();
            PeriodVar[] periods = _ibTimetablerContext.Periods.Where(x=>x.Week == 0)
                .Select(x=>new PeriodVar(x)).ToArray();
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
            for (int g = 0; g < Groups.Count; g++) {
                Group group = Groups[g];
                group.Classes = new List<LessonVar>();
                foreach (var lessonIdblockId in _ibTimetablerContext.LessonIdblockIds
                             .Where(x=>x.BlockId == group.Block)) {
                    LessonVar l = Lessons.Find(x => x.Id == lessonIdblockId.LessonId);
                    if (l.Level == group.Level && l.Year == group.Year) group.Classes.Add(l);
                    else if (Specials.Contains(l) && l.Year == group.Year) {
                        group.Classes.Add(l);
                    }
                }
                if (group.Classes.Count != 0) continue;
                Groups.RemoveAt(g);
                g--;
            }
        }

        private List<LessonVar> SolutionToLessons(List<string> solution, List<Group> groups, List<LessonVar> specials) {
            Random r = new Random();
            List<LessonVar> lessons = new List<LessonVar>();
            var roomIdlessonIds = _ibTimetablerContext.RoomIdlessonIds.ToList();
            foreach (Group g in groups) {
                var rooms = _ibTimetablerContext.Rooms.Select(x=>x.Id).ToList();
                List<int> indexes = solution.FindAll(x => int.Parse(x.Split(',')[0].ToString()) == g.Year 
                    && int.Parse(x.Split(',')[1].ToString()) == g.Block && x.Split(',')[2].ToString() == g.Level)
                    .Select(x => int.Parse(x.Split(',')[3])).ToList();
                List<PeriodVar> periods = new List<PeriodVar>();
                foreach (int index in indexes) {
                    periods.Add(g.Periods[index]);
                }
                periods = periods.OrderBy(x => x.Week).ThenBy(x=>x.Day)
                    .ThenBy(x=>x.TimePeriod).ToList();
                foreach (LessonVar l in g.Classes) {
                    int found = lessons.FindIndex(x => x.Id == l.Id);
                    if (found != -1) {
                        lessons[found].Periods = lessons[found].Periods.Concat(periods).ToList();
                        continue;
                    }
                    long roomId;
                    try {
                        roomId = roomIdlessonIds.Where(x => x.LessonId == l.Id).Select(x => x.RoomId)
                            .OrderBy(x => r.Next()).First(x => rooms.Contains(x));
                    }
                    catch (InvalidOperationException) {
                        roomId = 0;
                    }
                    LessonVar lesson = new LessonVar (l.Id, l.Name, l.Year, l.Level, l.ClassCode,
                        l.NumLessons, l.TeacherId, new List<PeriodVar>(periods), roomId);
                    lessons.Add(lesson);
                }
            }
            foreach (LessonVar l in lessons) {
                if (specials.FindIndex(x=>x.Id == l.Id) != -1) 
                    l.Periods = l.Periods.OrderBy(x=>r.Next()).Take((int)Math.Ceiling((double) l.NumLessons / (double) 2)
                    ).OrderBy(x=>x.Week).ThenBy(x=>x.Day).ThenBy(x=>x.TimePeriod).ToList();
                int length = l.Periods.Count;
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