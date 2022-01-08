using System;

namespace IB_Timetabler.Models {
    
    public class PeriodVar : Period {
        
        public int RemovedAtLevel { get; set; }

        public PeriodVar(long id, long week, long day, long timePeriod) {
            Id = id;
            Week = week;
            Day = day;
            TimePeriod = timePeriod;
            RemovedAtLevel = 0;
        }
        
        public PeriodVar(Period p) {
            Id = p.Id;
            Week = p.Week;
            Day = p.Day;
            TimePeriod = p.TimePeriod;
            RemovedAtLevel = 0;
        }

        private bool Equals(PeriodVar other) {
            return Week == other.Week && Day == other.Day && TimePeriod == other.TimePeriod;
        }

        public override bool Equals(object obj) {
            return obj is PeriodVar other && Equals(other);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Week, Day, TimePeriod);
        }
        
        public static bool operator ==(PeriodVar l1, PeriodVar l2) {
            return l1.Equals(l2);
        }
        
        public static bool operator !=(PeriodVar l1, PeriodVar l2) {
            return !l1.Equals(l2);
        }
    }
}