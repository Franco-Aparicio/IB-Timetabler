using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The LessonIdblockId object for the LessonIdblockId table in the database 
    public class LessonIdblockId {
        
        [Key]
        public long LessonId { get; set; }
        [Key]
        public long BlockId { get; set; }
    }
}
