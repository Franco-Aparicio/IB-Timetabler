using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class SavedLessonIdperiodId {
        [Key]
        public long SavedLessonId { get; set; }
        [Key]
        public long PeriodId { get; set; }
    }
}
