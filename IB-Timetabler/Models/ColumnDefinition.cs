namespace IB_Timetabler.Models {
    
    /// The custom ColumnDefinition class that allows for sorting tables by properties in the application 
    public class ColumnDefinition {

        public ColumnDefinition() {
            SortDirection = SortDirection.NotSet;
        }

        public string Property { get; set; }
        public string Title { get; set; }
        public SortDirection SortDirection { get; set; }
    }
}