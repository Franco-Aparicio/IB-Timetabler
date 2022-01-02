using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class SavedLesson {
        
        [Key]
        public long SaveId { get; set; }
        [Key]
        public string Lesson { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }
    }
}
