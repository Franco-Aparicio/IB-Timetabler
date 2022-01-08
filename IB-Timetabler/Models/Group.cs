using System;
using System.Collections.Generic;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class Group {

        public long Year { get; set; }
        public long Block { get; set; }
        public string Level { get; set; }
        public int NumLessons { get; set; }
        public List<LessonVar> Classes { get; set; }
        public PeriodVar[] Periods { get; set; }
        public List<int> Assigned { get; } = new List<int>();
        
        private bool Supports(Group other) {
            return ((Block == other.Block && Level == other.Level) || Year != other.Year)
                   && !Classes.Any(x=>other.Classes.Any(y=>x.TeacherId == y.TeacherId));
        }
        
        public override bool Equals(object obj) {
            return obj is Group other && Supports(other);
        }
        
        public override int GetHashCode() {
            return HashCode.Combine(Block, Level, Year);
        }

        public static bool operator ==(Group g1, Group g2) {
            return g1.Supports(g2);
        }
        
        public static bool operator !=(Group g1, Group g2) {
            return !g1.Supports(g2);
        }
        
        public int GetLeft() {
            int count = 0;
            foreach (PeriodVar p in Periods) {
                if (p.RemovedAtLevel == 0) count++;
            }
            return count;
        }
    }
}