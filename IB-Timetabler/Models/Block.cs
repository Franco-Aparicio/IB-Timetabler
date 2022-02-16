using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public class Block {
        
        [Key]
        public long Id { get; set; }
        public long BlockNum { get; set; }
    }
}
