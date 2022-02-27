using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The Block object for the Block table in the database 
    public class Block {
        
        [Key]
        public long Id { get; set; }
        public long BlockNum { get; set; }
    }
}
