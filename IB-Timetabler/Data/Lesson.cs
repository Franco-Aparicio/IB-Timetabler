using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IB_Timetabler.Data {

    public class Lesson {

        public int ID { get; set; }
        public string ClassCode { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        [NameValidator]
        public string Name { get; set; }
        public int Year { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        [Range(1, 70, ErrorMessage = "The number should be between {1} and {2}")]
        public int NumLessons { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        public string Teacher { get; set; }
        [MinLength(1, ErrorMessage = "{0} cannot be blank!")]
        public int[] Blocks { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        public string Level { get; set; }
        public List<string> Rooms { get; set; }
        public List<Period> Periods { get; set; }
    }
}