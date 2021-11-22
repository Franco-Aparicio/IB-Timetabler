using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class Block {
        
        [Key]
        public long Id { get; set; }
        public long BlockNum { get; set; }
    }
}
