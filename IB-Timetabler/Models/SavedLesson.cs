using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class SavedLesson {
        
        [Key]
        public long Id { get; set; }
        public long SaveId { get; set; }
        public long LessonId { get; set; }
        public long RoomId { get; set; }
    }
}
