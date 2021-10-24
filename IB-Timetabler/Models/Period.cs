using System;
using System.Globalization;

namespace IB_Timetabler.Models {
    
    public struct Period {
        
        public int Week { get; set; }
        public int Day { get; set; }
        public int TimePeriod { get; set; }
        public int RemovedAtLevel { get; set; }

        // public Period(int day, int timePeriod, int week = 0) {
        //     Week = week;
        //     Day = day;
        //     TimePeriod = timePeriod;
        //     RemovedAtLevel = 0;
        // }

        public override string ToString() {
            string w = Week == 0 ? "A" : "B";
            return $"Week: {w, -1} | Day: {CultureInfo.CurrentCulture.DateTimeFormat.DayNames[Day + 1], -9} | Period: {TimePeriod, -2}";
        }

        private bool Equals(Period other) {
            return Week == other.Week && Day == other.Day && TimePeriod == other.TimePeriod;
        }

        public override bool Equals(object obj) {
            return obj is Period other && Equals(other);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Week, Day, TimePeriod);
        }
        
        public static bool operator ==(Period l1, Period l2) {
            return l1.Equals(l2);
        }
        
        public static bool operator !=(Period l1, Period l2) {
            return !l1.Equals(l2);
        }
    }
}