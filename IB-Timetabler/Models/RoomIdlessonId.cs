using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class RoomIdlessonId {
        [Key]
        public long RoomId { get; set; }
        [Key]
        public long LessonId { get; set; }
    }
}
