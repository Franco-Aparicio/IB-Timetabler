using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IB_Timetabler.Models;

namespace IB_Timetabler.Models {
    
    public class Lesson {
        [Required(ErrorMessage = "{0} cannot be blank!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        [Range(12, 13, ErrorMessage = "The number should be between {1} and {2}")]
        public int Year { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        [Range(0, 35, ErrorMessage = "The number should be greater than {1}")]
        public int NumLessons { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        public string Teacher { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        [Range(0, 6, ErrorMessage = "The number should be between {1} and {2}")]
        public int Block { get; set; }
        [Required(ErrorMessage = "{0} cannot be blank!")]
        public string Group { get; set; }
        public List<string> Rooms { get; set; }
        public List<Period> Periods { get; set; }
        
        // public int Id { get; init; }
        // public string Name { get; set; }
        // public int Year { get; set; }
        // public int NumLessons { get; set; }
        // public string Teacher { get; set; }
        // public int Block { get; set; }
        // public int Group { get; set; }
        // public List<string> Rooms { get; set; }
        // public List<Period> Periods { get; set; }
        
        // public Lesson(string name, int year, int numLessons, string teacher, int block, int group) {
        //     Name = name;
        //     Year = year;
        //     NumLessons = numLessons;
        //     Group = group;
        //     Block = block;
        //     Teacher = teacher;
        // }
    }
}