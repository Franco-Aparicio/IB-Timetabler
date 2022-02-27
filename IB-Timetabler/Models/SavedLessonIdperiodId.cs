using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The SavedLessonIdperiodId object for the SavedLessonIdperiodId table in the database 
    public class SavedLessonIdperiodId {
        
        [Key]
        public long SavedLessonId { get; set; }
        [Key]
        public long PeriodId { get; set; }
    }
}
