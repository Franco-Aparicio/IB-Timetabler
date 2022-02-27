using System;
using System.Collections.Generic;
using System.Linq;

namespace IB_Timetabler.Models {
    
    /// The object used to group Lessons as one variable when generating timetables 
    public class Group {

        /// The year group of the LessonVar objects in the Group 
        public long Year { get; set; }
        /// The Block of the LessonVar objects in the Group 
        public long Block { get; set; }
        /// The Level of the LessonVar objects in the Group 
        public string Level { get; set; }
        /// The number of lessons the Group needs to have scheduled 
        public int NumLessons { get; set; }
        /// The LessonVar objects within the Group 
        public List<LessonVar> Classes { get; set; }
        /// The domain of available PeriodVar objects for the Group to be assigned 
        public PeriodVar[] Periods { get; set; }
        /// The Ids of the PeriodVar objects that have been assigned to the Group 
        public List<int> Assigned { get; } = new List<int>();
        
        /// Determines whether the Group is supported by (can be scheduled at the same time as) another Group 
        private bool Supports(Group other) {
            return ((Block == other.Block && Level == other.Level) || Year != other.Year)
                   && !Classes.Any(x=>other.Classes.Any(y=>x.TeacherId == y.TeacherId));
        }
        
        /// Overrides default equality definition to Supports 
        public override bool Equals(object obj) {
            return obj is Group other && Supports(other);
        }
        
        public override int GetHashCode() {
            return HashCode.Combine(Block, Level, Year);
        }

        /// Overrides default == operator to Supports 
        public static bool operator ==(Group g1, Group g2) {
            return g1.Supports(g2);
        }
        
        /// Overrides the default != operator to Supports 
        public static bool operator !=(Group g1, Group g2) {
            return !g1.Supports(g2);
        }
        
        /// Returns the current number of periods remaining in the domain of the Group (used during Search in the Scheduler) 
        public int GetLeft() {
            int count = 0;
            foreach (PeriodVar p in Periods) {
                if (p.RemovedAtLevel == 0) count++;
            }
            return count;
        }
    }
}