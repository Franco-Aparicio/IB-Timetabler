using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Models {

    public class Lesson {

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
        public string Group { get; set; }
        public List<string> Rooms { get; set; }
        public List<Period> Periods { get; set; }
        
        // public int ClassCode { get; init; }
        // public string Name { get; set; }
        // public int Year { get; set; }
        // public int NumLessons { get; set; }
        // public string Teacher { get; set; }
        // public int Blocks { get; set; }
        // public int Group { get; set; }
        // public List<string> Rooms { get; set; }
        // public List<Period> Periods { get; set; }
        
        // public Lesson(string name, int year, int numLessons, string teacher, int block, int group) {
        //     Name = name;
        //     Year = year;
        //     NumLessons = numLessons;
        //     Group = group;
        //     Blocks = block;
        //     Teacher = teacher;
        // }
    }
}