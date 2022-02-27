using System.Collections.Generic;

namespace IB_Timetabler.Models {
    
    /// Used by the Scheduler and inherits properties from the Lesson object 
    public class LessonVar : Lesson {
        
        /// Allows LessonVar objects to be assigned scheduled PeriodVar objects 
        public List<PeriodVar> Periods { get; set; }
        /// Allows LessonVar objects to be assigned scheduled rooms 
        public long RoomId { get; }

        public LessonVar(long id, string name, long year, string level, string classCode, long numLessons,
            long teacherId, List<PeriodVar> periods, long roomId) {
            Id = id;
            Name = name;
            Year = year;
            Level = level;
            ClassCode = classCode;
            NumLessons = numLessons;
            TeacherId = teacherId;
            Periods = periods;
            RoomId = roomId;
        }
        
        /// Overload constructor to convert a Lesson into a LessonVar 
        public LessonVar(Lesson l) {
            Id = l.Id;
            Name = l.Name;
            Year = l.Year;
            Level = l.Level;
            ClassCode = l.ClassCode;
            NumLessons = l.NumLessons;
            TeacherId = l.TeacherId;
        }
    }
}