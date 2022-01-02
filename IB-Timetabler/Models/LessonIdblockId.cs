using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class LessonIdblockId {
        
        [Key]
        public long LessonId { get; set; }
        [Key]
        public long BlockId { get; set; }
    }
}
