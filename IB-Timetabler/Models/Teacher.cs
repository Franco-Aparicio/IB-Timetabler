using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The Teacher object for the Teacher table in the database 
    public class Teacher {
        
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
