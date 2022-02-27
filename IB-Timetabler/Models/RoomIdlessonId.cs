using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The RoomIdlessonId object for the RoomIdlessonId table in the database 
    public class RoomIdlessonId {
        
        [Key]
        public long RoomId { get; set; }
        [Key]
        public long LessonId { get; set; }
    }
}
