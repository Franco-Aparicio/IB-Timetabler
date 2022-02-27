using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The Save object for the Save table in the database 
    public class Save {
        
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
