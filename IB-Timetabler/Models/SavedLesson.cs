#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class SavedLesson {
        public long SaveId { get; set; }
        public string Lesson { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }
    }
}
