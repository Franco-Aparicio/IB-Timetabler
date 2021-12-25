using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class Lesson {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "The lesson must have a name!")]
        public string Name { get; set; }
        public long Year { get; set; }
        public string Level { get; set; }
        public string ClassCode { get; set; }
        public long NumLessons { get; set; }
        public long TeacherId { get; set; }
    }
}
