using System.Collections.Generic;

namespace TimetableGenerator {
    
    public class Lesson {

        public string Name { get; }
        public int Year { get; }
        public int NumLessons { get; }
        public string Teacher { get; }
        public int Block { get; }
        public int Group { get; }
        public List<string> Rooms = new List<string>();
        public List<Period> Periods { get; set; }
        
        public Lesson(string name, int year, int numLessons, string teacher, int block, int group) {
            Name = name;
            Year = year;
            NumLessons = numLessons;
            Group = group;
            Block = block;
            Teacher = teacher;
        }
    }
}