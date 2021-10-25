using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

// using NPOI.SS.UserModel;
// using NPOI.XSSF.UserModel;

namespace TimetableGenerator {
    
    class Program {

        static void Main(string[] args) {
            // object[] staffing = LoadStaffing(args[0]);
            // var classes = (Dictionary<string, List<Lesson>>)staffing[0];
            // var teachers = (Dictionary<string, List<Teacher>>)staffing[1];
            // Day[,] weeks = new Day[2, 5];
            List<Lesson>[] lessons = LoadClasses(args[0]);
            List<Lesson> classes = lessons[0];
            List<Lesson> specials = lessons[1];
            List<Group> groups = AssignToGroups(classes);
            Scheduler scheduler = new Scheduler();
            if (scheduler.Schedule(groups)) {
                classes = SolutionToLessons(scheduler.Solution, groups, specials);
                // PrintSolution(scheduler.Solution, groups);
                PrintSolution(classes);
                // foreach (Lesson c in specials) {
                //     Console.WriteLine($"Name: {c.Name, -15}  Year: {c.Year, -3}  Lessons: {c.NumLessons, -3}  Teacher: {c.Teacher, -3}");
                // }
            }
            else {
                Console.WriteLine("No Solution Found!");
            }
        }

        static List<Lesson>[] LoadClasses(string file) {
            string path = Path.GetFullPath("./"); // Get current path
            // If current directory is not "TimetableGenerator", go back 3 directories (if program is run in ./bin/Debug/net5.0)
            if (path.Substring(path.Length - 14, 13) != "TimetableGenerator") path += @"../../../";
            path += file;
            // Cleanup the path string
            path = Path.GetFullPath(path);
            using StreamReader reader = File.OpenText(path);
            using CsvReader f = new CsvReader(reader, CultureInfo.CurrentCulture);
            List<Lesson> classes = f.GetRecords<Lesson>().ToList();
            // foreach (Lesson c in classes) {
            //     Console.WriteLine($"Name: {c.Name, -15}  Year: {c.Year, -3}  Lessons: {c.Lessons, -3}  Teacher: {c.Teacher, -3}");
            // }
            List<Period> defaultP7 = new List<Period>();
            for (int i = 0; i < 5; i++) {
                for (int j = 1; j <= 7; j++) {
                    defaultP7.Add(new Period(i, j));
                }
            }
            foreach (Lesson c in classes) {
                c.Periods = new List<Period>(defaultP7);
                // c.SetConstraints(classes);
            }
            List<Lesson> specials = new List<Lesson>();
            for (int i = 0; i < classes.Count; i++) {
                if (classes[i].NumLessons is 4 or 6) continue;
                specials.Add(classes[i]);
                // classes.RemoveAt(i);
                // i--;
            }
            return new [] {classes, specials};
        }

        private static List<Group> AssignToGroups(List<Lesson> classes) {
            List<Group> groups = new List<Group>();
            for (int i = 1; i <= 6; i++) {
                for (int j = 0; j < 2; j++) {
                    groups.Add(new Group(j, i, j == 0 ? 2 : 3));
                }
            }
            for (int group = 0; group < groups.Count; group++) {
                Group g = groups[group];
                g.Classes = classes.Where(x =>
                    (x.Block == g.Block) &&
                    (x.Group == g.GroupNum)).ToList();
                try {
                    g.Periods = g.Classes[0].Periods.ToArray();
                }
                catch (ArgumentOutOfRangeException) {
                    groups.RemoveAt(group);
                    group--;
                }
            }
            return groups;
        }

        private static List<Lesson> SolutionToLessons(List<string> solution, List<Group> groups, List<Lesson> specials) {
            Random r = new Random();
            List<Lesson> classes = new List<Lesson>();
            foreach (Group g in groups) {
                List<int> indexes = solution.FindAll(x => int.Parse(x.Split(',')[0].ToString()) == g.Block && int.Parse(x.Split(',')[1].ToString()) == g.GroupNum).Select(x=>int.Parse(x.Split(',')[2].ToString())).ToList();
                List<Period> periods = new List<Period>();
                foreach (int index in indexes) {
                    // Period p = g.Periods[index];
                    periods.Add(g.Periods[index]);
                    // periods.Add(new Period(p.Day, p.TimePeriod, 1));
                }
                // List<Period> periods = solution.FindAll(x => int.Parse(x.Split(',')[0].ToString()) == g.Block && int.Parse(x.Split(',')[1].ToString()) == g.GroupNum).Select(x=>int.Parse(x.Split(',')[2].ToString())).Select(index => g.Periods[index]).ToList();
                periods = periods.OrderBy(x => x.Week).ThenBy(x=>x.Day).ThenBy(x=>x.TimePeriod).ToList();
                foreach (Lesson l in g.Classes) {
                    int found = classes.FindIndex(x => x.Name == l.Name);
                    if (found != -1) {
                        classes[found].Periods = classes[found].Periods.Concat(periods).ToList();
                        continue;
                    }
                    Lesson c = new Lesson(l.Name, l.Year, l.NumLessons, l.Teacher, l.Block, l.Group);
                    c.Periods = new List<Period>(periods);
                    classes.Add(c);
                }
            }
            foreach (Lesson l in classes) {
                if (specials.FindIndex(x => x.Name == l.Name) != -1) {
                    l.Periods = l.Periods.OrderBy(x => r.Next()).Take((int)Math.Ceiling((double) l.NumLessons / (double) 2)).OrderBy(x=>x.Week).ThenBy(x=>x.Day).ThenBy(x=>x.TimePeriod).ToList();
                }
                int length = l.Periods.Count;
                for (int period = 0; period < (length < l.NumLessons/2 ? length: l.NumLessons/2); period++) {
                    Period p = l.Periods[period];
                    l.Periods.Add(new Period(p.Day, p.TimePeriod, 1));
                }
            }
            return classes;
        }

        private static void PrintSolution(List<string> solution, List<Group> groups) {
            Console.WriteLine(groups[0].Periods.Length);
            List<Period> count = new List<Period>();
            foreach (Group g in groups) {
                Console.Write($"Block: {g.Block, -2} Group: {g.GroupNum, -2}  Needed: {g.NumLessons, -2}  Assigned: ");
                foreach (string pair in solution.FindAll(x => int.Parse(x.Split(',')[0].ToString()) == g.Block && int.Parse(x.Split(',')[1].ToString()) == g.GroupNum)) {
                    Console.Write($"{g.Periods[int.Parse(pair.Split(',')[2])].ToString(), -40}");
                    count.Add(g.Periods[int.Parse(pair.Split(',')[2])]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(count.Distinct().Count());
        }
        
        private static void PrintSolution(List<Lesson> classes) {
            foreach (Lesson l in classes) {
                Console.Write($"Class: {l.Name,-15}  Needed: {l.NumLessons,-2}  Assigned: {l.Periods.Count, -2}");
                foreach (Period p in l.Periods) {
                    Console.Write($"{p.ToString(), -40}");
                }
                Console.WriteLine();
            }
        }

        // static object[] LoadStaffing(string file) {
        //     string path = Path.GetFullPath("./"); // Get current path
        //     // If current directory is not "TimetableGenerator", go back 3 directories (if program is run in ./bin/Debug/net5.0)
        //     if (path.Substring(path.Length - 14, 13) != "TimetableGenerator") path += @"../../../";
        //     path += file;
        //     // Cleanup the path string
        //     path = Path.GetFullPath(path);
        //     IWorkbook wb;
        //     using (FileStream File = new FileStream(path, FileMode.Open, FileAccess.Read)) {
        //         wb = new XSSFWorkbook(File); // Load Excel file from path
        //     }
        //     // Initialize class dictionary and Teachers dictionary (separated by sheets)
        //     Dictionary<string, List<Lesson>> classes = new();
        //     Dictionary <string, List<Teacher>> teachers = new();
        //     for (int s = 0; s < wb.NumberOfSheets; s++) { // Loop through each sheet of the file
        //         ISheet sheet = wb.GetSheetAt(s);
        //         classes.Add(sheet.SheetName, new List<Lesson>());
        //         teachers.Add(sheet.SheetName, new List<Teacher>());
        //         int classIndex = -1; // Column index with the name of each class
        //         int doublesCol = 0;
        //         bool skip = true;
        //         for (int rowNum = sheet.FirstRowNum; rowNum <= sheet.LastRowNum; rowNum++) {
        //             IRow row = sheet.GetRow(rowNum);
        //             if (row is null || row.Cells.Count == 0) continue;
        //             if (skip) {
        //                 for (int c = 0; c < row.Cells.Count; c++) {
        //                     ICell currentCell = row.Cells[c];
        //                     if (currentCell.CellType == CellType.String && currentCell.StringCellValue.ToLower() == "class") {
        //                         classIndex = currentCell.ColumnIndex;
        //                         doublesCol = row.GetCell(classIndex + 2).StringCellValue.ToLower() == "doubles per week" ? 1: 0;
        //                     }
        //                     if (classIndex != -1 && c > classIndex + doublesCol && currentCell.CellType != CellType.Blank && currentCell.StringCellValue.Length < 5) {
        //                         teachers[sheet.SheetName].Add(new Teacher(currentCell.StringCellValue, currentCell.ColumnIndex));
        //                     }
        //                 }
        //                 if (classIndex != -1) {
        //                     skip = false;
        //                     continue;
        //                 }
        //             }
        //             ICell cell = row.GetCell(classIndex);
        //             if (skip || cell.CellType == CellType.Blank) continue;
        //             if (cell.CellType == CellType.String && cell.StringCellValue.ToLower() == "total") break;
        //             string name = "";
        //             int lessons = (int)row.GetCell(classIndex + 1).NumericCellValue;
        //             try {
        //                 name = cell.StringCellValue;
        //             }
        //             catch (InvalidOperationException) {
        //                 name = cell.NumericCellValue.ToString();
        //             }
        //             // try {
        //             //     lessons = (int)row.GetCell(classIndex + 1).NumericCellValue;
        //             // }
        //             // catch (InvalidOperationException) {
        //             //     lessons = int.Parse(row.GetCell(classIndex + 1).StringCellValue);
        //             // }
        //             if (doublesCol == 0) {
        //                 classes[sheet.SheetName].Add(new Lesson(name, lessons));
        //             }
        //             else {
        //                 classes[sheet.SheetName].Add(new Lesson(name, lessons, (int)row.GetCell(classIndex + 2).NumericCellValue));
        //             }
        //             foreach (ICell c in row) {
        //                 foreach (Teacher teacher in teachers[sheet.SheetName]) {
        //                     if (c.ColumnIndex != teacher.Column) continue;
        //                     lessons = (int)row.GetCell(teacher.Column).NumericCellValue;
        //                     if (lessons == 0) continue;
        //                     // try {
        //                     //     lessons = (int)row.GetCell(teacher.Column).NumericCellValue;
        //                     // }
        //                     // catch (InvalidOperationException) {
        //                     //     lessons = int.Parse(row.GetCell(teacher.Column).StringCellValue);
        //                     // }
        //                     teacher.AddClass(new Lesson(name, lessons));
        //                 }
        //             }
        //         }
        //     }
        //     // foreach (var pair in classes) {
        //     //     foreach (Lesson c in pair.Value) {
        //     //         Console.WriteLine($"Name: {c.Name}\tLessons: {c.Lessons}\tDoubles: {c.Doubles}\tSheet: {pair.Key}");
        //     //     }
        //     // }
        //     // foreach (var pair in teachers) {
        //     //     foreach (Teacher teacher in pair.Value) {
        //     //         Console.WriteLine($"Name: {teacher.Name}\tColumn: {teacher.Column}");
        //     //         foreach (Lesson c in teacher.Classes) {
        //     //             Console.WriteLine($"Class: {c.Name} Lessons: {c.Lessons}");
        //     //         }
        //     //         Console.WriteLine();
        //     //     }
        //     // }
        //     return new object[] {classes, teachers};
        // }
    }
}