// using System;
// using System.Collections.Generic;
// using System.Linq;
//
// namespace IB_Timetabler.Models {
//     
//     public class Group {
//         
//         public int Block { get; set; }
//         public int GroupNum { get; set; }
//         public int NumLessons { get; set; }
//         public List<Lesson> Classes { get; set; }
//         public Period[] Periods { get; set; }
//         public List<int> Assigned { get; } = new List<int>();
//         
//         private bool Equals(Group other) {
//             return Block == other.Block && GroupNum == other.GroupNum
//                         && !Classes.Any(x=>other.Classes.Any(y=>x.TeacherId == y.TeacherId));
//         }
//
//         public override bool Equals(object obj) {
//             return obj is Group other && Equals(other);
//         }
//
//         public override int GetHashCode() {
//             return HashCode.Combine(Block, GroupNum);
//         }
//
//         public static bool operator ==(Group g1, Group g2) {
//             return g1.Equals(g2);
//         }
//         
//         public static bool operator !=(Group g1, Group g2) {
//             return !g1.Equals(g2);
//         }
//         
//         public int GetLeft() {
//             int count = 0;
//             foreach (Period p in Periods) {
//                 if (p.RemovedAtLevel == 0) count++;
//             }
//             return count;
//         }
//     }
// }