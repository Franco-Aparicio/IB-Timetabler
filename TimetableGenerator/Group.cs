using System;
using System.Collections.Generic;
using System.Linq;

namespace TimetableGenerator {
    
    public class Group {
        
        public int Block { get; }
        public int GroupNum { get; }
        public int NumLessons { get; set; }
        public List<Lesson> Classes { get; set; }
        public Period[] Periods { get; set; }
        public List<int> Assigned { get; }
        
        public Group(int group, int block, int numLessons) {
            GroupNum = group;
            Block = block;
            NumLessons = numLessons;
            Assigned = new List<int>();
        }

        public Group(int group) {
            GroupNum = group;
        }
        private bool Equals(Group other) {
            return Block == other.Block && GroupNum == other.GroupNum && !Classes.Any(x=>other.Classes.Any(y=>x.Teacher == y.Teacher));
        }

        public override bool Equals(object obj) {
            return obj is Group other && Equals(other);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Block, GroupNum);
        }

        public static bool operator ==(Group g1, Group g2) {
            return g1.Equals(g2);
        }
        
        public static bool operator !=(Group g1, Group g2) {
            return !g1.Equals(g2);
        }
        
        public int GetLeft() {
            int count = 0;
            foreach (Period p in Periods) {
                if (p.RemovedAtLevel == 0) count++;
            }
            return count;
        }
    }
}