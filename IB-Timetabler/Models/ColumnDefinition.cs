namespace IB_Timetabler.Models {
    
    public class ColumnDefinition {

        public ColumnDefinition() {
            SortDirection = SortDirection.NotSet;
        }

        public string Property { get; set; }
        public string Title { get; set; }
        public SortDirection SortDirection { get; set; }
    }
}