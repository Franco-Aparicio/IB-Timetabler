using System.Collections.Generic;

namespace TimetableGenerator {
    
    public class Lesson {

        public string Name { get; }
        public int Year { get; }
        public int NumLessons { get; }
        public string Teacher { get; }
        public int Block { get; }
        public int Group { get; }
        public int[] Weeks { get; }
        public List<string> Rooms = new List<string>();
        public List<Period> Periods { get; set; }
        
        public Lesson(string name, int year, int numLessons, string teacher, int block, int group) {
            Name = name;
            Year = year;
            NumLessons = numLessons;
            Group = group;
            Block = block;
            Teacher = teacher;
            Weeks = new int[2];
            if (NumLessons % 2 == 0) {
                Weeks[0] = NumLessons / 2;
                Weeks[1] = NumLessons / 2;
            }
            else {
                Weeks[0] = 1 + NumLessons / 2;
                Weeks[1] = NumLessons / 2;
            }
        }
    }
}