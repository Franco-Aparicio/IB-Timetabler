﻿using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The Lesson object for the Lesson table in the database 
    public class Lesson {
        
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public long Year { get; set; }
        public string Level { get; set; }
        public string ClassCode { get; set; }
        public long NumLessons { get; set; }
        public long TeacherId { get; set; }
    }
}
