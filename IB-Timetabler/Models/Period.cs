using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IB_Timetabler.Models {
    
    /// The Period object for the Period table in the database 
    public class Period {
        
        [Key]
        public long Id { get; set; }
        public long Week { get; set; }
        public long Day { get; set; }
        public long TimePeriod { get; set; }
        private string[] Days = new[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        
        public override string ToString() {
            string w = Week == 0 ? "A" : "B";
            return $"Week: {w}, {Days[Day]}, Period: {TimePeriod.ToString()}";
        }
    }
}
