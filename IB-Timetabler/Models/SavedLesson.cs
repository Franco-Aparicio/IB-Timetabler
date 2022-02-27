using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The SavedLesson object for the SavedLesson table in the database 
    public class SavedLesson {
        
        [Key]
        public long Id { get; set; }
        public long SaveId { get; set; }
        public long LessonId { get; set; }
        public long RoomId { get; set; }
    }
}
