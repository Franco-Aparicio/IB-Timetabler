using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IB_Timetabler.Models {
    
    /// The algorithm used to assign PeriodVar objects to Group objects and hence generate a timetable 
    public class Scheduler {
        
        /// Where the solution is stored as a List of strings corresponding to actions taken to generate the timetable 
        public List<string> Solution { get; set; }
        /// Connects a given action to a list of [Group, value] pairs that do not support it (to determine which values must be 
        /// removed from the domain of those Group objects) after a given action 
        private Dictionary<string, List<Group[]>> NotSupport;
        private Random r = new Random();
        /// Is periodically checked by another thread to cancel timetable generation 
        private bool IsStopRequested;

        /// Initializes and populates the NotSupport property, starts a Task to cancel timetable generation if no solution is found after
        /// 5 minutes, and begins Search to assign PeriodVar objects to Group objects 
        public bool Schedule(List<Group> groups) {
            IsStopRequested = false;
            NotSupport = new Dictionary<string, List<Group[]>>();
            foreach (Group g in groups) {
                for (int i = 0; i < g.Periods.Length; i++) {
                    NotSupport[GetActionString(g, i)] = new List<Group[]>();
                }
            }
            Solution = new List<string>();
            for (int group = 0; group < groups.Count; group++) {
                for (int group2 = group; group2 < groups.Count; group2++) {
                    if (group2 == group) continue;
                    Group g = groups[group];
                    Group g2 = groups[group2];
                    for (int i = 0; i < g.Periods.Length; i++) {
                        for (int j = 0; j < g2.Periods.Length; j++) {
                            if (g == g2 && g.Periods[i] == g2.Periods[j]) continue;
                            NotSupport[GetActionString(g2, j)].Add(new[] { g, new Group { NumLessons = i } });
                            NotSupport[GetActionString(g, i)].Add(new[] { g2, new Group { NumLessons = j } });
                        }
                    }
                }
            }
            var cancelSrc = new CancellationTokenSource();
            var token = cancelSrc.Token;
            Task t = new Task(() => {
                for (int i = 0; i < 60; i++) {
                    Thread.Sleep(TimeSpan.FromSeconds(5));
                    if (token.IsCancellationRequested) return;
                }
                Stop(); }, token);
            t.Start();
            bool solved = Search(groups, 1);
            // Stop the cancellation Task if Search has completed before the timeout limit 
            cancelSrc.Cancel();
            return solved;
        }

        /// Recursively searches through the domains of Groups to assign them PeriodVar objects and subsequently generate a timetable 
        private bool Search(List<Group> groups, int level) {
            // If the generation has been cancelled before a solution is found, return false 
            if (IsStopRequested) return false;
            // Selects a Group to assign PeriodVar objects to (determined by the minimum remaining values heuristic) 
            Group g = SelectGroup(groups);
            // Order the PeriodVar objects to assign to the Group first (earlier periods first to minimize period 7 lessons) 
            List<int> periods = SelectPeriods(g);
            // Loop through each possible PeriodVar objects in the domain of the selected Group 
            foreach (int index in periods) {
                if (IsStopRequested) return false;
                // Gets the string to represent the current action (assigning the selected Group the current PeriodVar) 
                string action = GetActionString(g, index);
                // Adds the current action to the solution and to the assigned values in the selected Group 
                Solution.Add(action);
                g.Assigned.Add(index);
                // If this is the last Group to be assigned PeriodVar objects and the required number of PeriodVar objects have been
                // assigned to the current Group, a full solution has been found (return true) 
                if (groups.Count == 1 && g.Assigned.Count == g.NumLessons) return true;
                // If the current Group has been assigned all required PeriodVar objects, remove it from groups 
                if (g.Assigned.Count == g.NumLessons)
                    groups = groups.Where(x => x.GetHashCode() != g.GetHashCode()).ToList();
                // Trim the domains of Group objects in NotSupport and continue to Search another level, if a solution is found at a 
                // deeper level, return true 
                if (CheckForward(groups, level, g, index) &&
                    Search(groups, level + 1)) return true;
                // Otherwise, remove the action from the solution and from the assigned values of the selected Group 
                Solution.Remove(action);
                g.Assigned.Remove(index);
                // Restores groups to how it was prior to the action taken 
                groups = Restore(groups, level);
            }
            // If no solution has been found after exhausting every possibility, return false 
            return false;
        }

        /// Trims the domains of Group objects in NotSupport according to the given value val assigned to the given Group g. 
        /// Returns false if there are not enough PeriodVar objects in the trimmed domains for the required number for any Group 
        private bool CheckForward(List<Group> groups, int level, Group g, int val) {
            foreach (Group[] pair in NotSupport[GetActionString(g, val)]) {
                // If the PeriodVar has already been trimmed or the group has been removed from groups, continue to next iteration 
                if (pair[0].Periods[pair[1].NumLessons].RemovedAtLevel != 0 ||
                    groups.All(x => x.GetHashCode() != pair[0].GetHashCode())) continue;
                pair[0].Periods[val].RemovedAtLevel = level;
                if (!HasRemainingPeriods(pair[0])) return false;
            }
            return true;
        }

        /// Restores the domains of Group objects in groups to their states before a given level of Search 
        private List<Group> Restore(List<Group> groups, int level) {
            foreach (Group g in groups) {
                for (int i = 0; i < g.Periods.Length; i++) {
                    if (g.Periods[i].RemovedAtLevel == level) {
                        g.Periods[i].RemovedAtLevel = 0;
                    }
                }
            }
            return groups;
        }

        /// Checks whether a solution is still possible for a given Group (if it has enough values in its domain for the required number) 
        private bool HasRemainingPeriods(Group g) {
            int count = 0;
            for (int i = 0; i < g.Periods.Length; i++) {
                if (g.Periods[i].RemovedAtLevel == 0) count++;
                if (count == g.NumLessons) return true;
            }
            return false;
        }

        /// Sorts PeriodVar indices remaining in the domain of a given Group by period (to avoid period 7 lessons) 
        private List<int> SelectPeriods(Group g) {
            List<int> indices = new List<int>();
            for (int i = 0; i < g.Periods.Length; i++) {
                if (g.Periods[i].RemovedAtLevel != 0 ||
                    g.Assigned.Contains(i)) continue;
                indices.Add(i);
            }
            return indices.OrderBy(x=>g.Periods[x].TimePeriod).ThenBy(x=> r.Next()).ToList();
        }
        
        /// Selects a Group to assign PeriodVar objects to (determined by the minimum remaining values heuristic) 
        private Group SelectGroup(List<Group> groups) {
            return groups.OrderBy(x => x.GetLeft()).ThenBy(x => r.Next()).First();
        }
        
        /// Creates the string to represent the current action (assigning the given Group the given value) 
        private string GetActionString(Group g, int v) {
            return $"{g.Year.ToString()},{g.Block.ToString()},{g.Level},{v.ToString()}";
        }

        private void Stop() {
            IsStopRequested = true;
        }
    }
}