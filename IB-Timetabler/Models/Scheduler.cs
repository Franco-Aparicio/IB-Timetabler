using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IB_Timetabler.Models {
    
    public class Scheduler {
        
        public List<string> Solution { get; set; }
        private Dictionary<string, List<Group[]>> NotSupport;
        private Random r = new Random();
        private bool IsStopRequested;

        public bool Schedule(List<Group> groups) {
            IsStopRequested = false;
            NotSupport = new Dictionary<string, List<Group[]>>();
            foreach (Group g in groups) {
                for (int i = 0; i < g.Periods.Length; i++) {
                    NotSupport[GetKey(g, i)] = new List<Group[]>();
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
                            NotSupport[GetKey(g2, j)].Add(new[] { g, new Group { NumLessons = i } });
                            NotSupport[GetKey(g, i)].Add(new[] { g2, new Group { NumLessons = j } });
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
            cancelSrc.Cancel();
            return solved;
        }

        private bool Search(List<Group> groups, int level) {
            if (IsStopRequested) return false;
            Group g = SelectGroup(groups);
            List<int> periods = SelectPeriods(g);
            foreach (int index in periods) {
                if (IsStopRequested) return false;
                string item = GetKey(g, index);
                Solution.Add(item);
                g.Assigned.Add(index);
                if (groups.Count == 1 && g.Assigned.Count == g.NumLessons) return true;
                if (g.Assigned.Count == g.NumLessons)
                    groups = groups.Where(x => x.GetHashCode() != g.GetHashCode()).ToList();
                if (CheckForward(groups, level, g, index) &&
                    Search(groups, level + 1)) return true;
                Solution.Remove(item);
                g.Assigned.Remove(index);
                groups = Restore(groups, level);
            }
            return false;
        }

        private bool CheckForward(List<Group> groups, int level, Group g, int val) {
            foreach (Group[] pair in NotSupport[GetKey(g, val)]) {
                if (pair[0].Periods[pair[1].NumLessons].RemovedAtLevel != 0 ||
                    groups.All(x => x.GetHashCode() != pair[0].GetHashCode())) continue;
                pair[0].Periods[val].RemovedAtLevel = level;
                if (!HasRemainingPeriods(pair[0])) return false;
            }
            return true;
        }

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

        private bool HasRemainingPeriods(Group g) {
            int count = 0;
            for (int i = 0; i < g.Periods.Length; i++) {
                if (g.Periods[i].RemovedAtLevel == 0) count++;
                if (count == g.NumLessons) return true;
            }
            return false;
        }

        private List<int> SelectPeriods(Group g) {
            List<int> indices = new List<int>();
            for (int i = 0; i < g.Periods.Length; i++) {
                if (g.Periods[i].RemovedAtLevel != 0 ||
                    g.Assigned.Contains(i)) continue;
                indices.Add(i);
            }
            return indices.OrderBy(x=>g.Periods[x].TimePeriod).ThenBy(x=> r.Next()).ToList();
        }
        
        private Group SelectGroup(List<Group> groups) {
            return groups.OrderBy(x => x.GetLeft()).ThenBy(x => r.Next()).First();
        }
        
        private string GetKey(Group g, int p) {
            return $"{g.Year.ToString()},{g.Block.ToString()},{g.Level},{p.ToString()}";
        }

        private void Stop() {
            IsStopRequested = true;
        }
    }
}