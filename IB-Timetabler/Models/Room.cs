using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The Room object for the Room table in the database 
    public class Room {
        
        [Key]
        public long Id { get; set; }
        public string Number { get; set; }
        public long Floor { get; set; }
    }
}
