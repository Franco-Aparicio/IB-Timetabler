using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public class Teacher {
        
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
