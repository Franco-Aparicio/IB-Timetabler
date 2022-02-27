using System;

namespace IB_Timetabler.Models {
    
    /// Used by the Scheduler and inherits properties from the Period object 
    public class PeriodVar : Period {
        
        /// Allows PeriodVar objects to keep track of where they have been removed from the domain of a Group 
        public int RemovedAtLevel { get; set; }
        
        public PeriodVar(Period p) {
            Id = p.Id;
            Week = p.Week;
            Day = p.Day;
            TimePeriod = p.TimePeriod;
            RemovedAtLevel = 0;
        }

        /// Compares a PeriodVar's Week, Day, and TimePeriod with those of another PeriodVar 
        private bool Equals(PeriodVar other) {
            return Week == other.Week && Day == other.Day && TimePeriod == other.TimePeriod;
        }

        /// Overrides the default equality comparer to only compare a PeriodVar's Week, Day, and TimePeriod 
        public override bool Equals(object obj) {
            return obj is PeriodVar other && Equals(other);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Week, Day, TimePeriod);
        }
        
        /// Overrides the default == operator to only compare a PeriodVar's Week, Day, and TimePeriod 
        public static bool operator ==(PeriodVar l1, PeriodVar l2) {
            return l1.Equals(l2);
        }
        
        /// Overrides the default != operator to only compare a PeriodVar's Week, Day, and TimePeriod 
        public static bool operator !=(PeriodVar l1, PeriodVar l2) {
            return !l1.Equals(l2);
        }
    }
}