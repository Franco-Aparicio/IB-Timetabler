#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class Period {
        public long Id { get; set; }
        public long Week { get; set; }
        public long Day { get; set; }
        public long TimePeriod { get; set; }
    }
}
