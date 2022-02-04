using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IB_Timetabler.Models {
    
    public partial class IBTimetablerContext : DbContext {
        
        public IBTimetablerContext() { }

        public IBTimetablerContext(DbContextOptions<IBTimetablerContext> options) : base(options) { }

        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<LessonIdblockId> LessonIdblockIds { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomIdlessonId> RoomIdlessonIds { get; set; }
        public virtual DbSet<Save> Saves { get; set; }
        public virtual DbSet<SavedLesson> SavedLessons { get; set; }
        public virtual DbSet<SavedLessonIdperiodId> SavedLessonIdperiodIds { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<Block>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.BlockNum).HasColumnName("Block");
            });
            
            modelBuilder.Entity<Lesson>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ClassCode).IsRequired();
                entity.Property(e => e.Level).IsRequired();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            });
            
            modelBuilder.Entity<LessonIdblockId>(entity => {
                entity.HasKey(x => new {x.BlockId, x.LessonId});
                entity.ToTable("LessonIDBlockID");
                entity.Property(e => e.BlockId).HasColumnName("BlockID");
                entity.Property(e => e.LessonId).HasColumnName("LessonID");
            });
            
            modelBuilder.Entity<Period>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Week).HasColumnName("Week");
                entity.Property(e => e.Day).HasColumnName("Day");
                entity.Property(e => e.TimePeriod).HasColumnName("TimePeriod");
            });
            
            modelBuilder.Entity<Room>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Number).IsRequired();
            });
            
            modelBuilder.Entity<RoomIdlessonId>(entity => {
                entity.HasKey(x => new {x.LessonId, x.RoomId});
                entity.ToTable("RoomIDLessonID");
                entity.Property(e => e.LessonId).HasColumnName("LessonID");
                entity.Property(e => e.RoomId).HasColumnName("RoomID");
            });
            
            modelBuilder.Entity<Save>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Name).IsRequired();
            });
            
            modelBuilder.Entity<SavedLesson>(entity => {
                entity.HasKey(x => new {x.Id});
                entity.Property(e => e.Id).IsRequired().HasColumnName("ID");
                entity.Property(e => e.LessonId).IsRequired().HasColumnName("LessonID");
                entity.Property(e => e.RoomId).IsRequired().HasColumnName("RoomID");
                entity.Property(e => e.SaveId).IsRequired().HasColumnName("SaveID");
            });
            
            modelBuilder.Entity<SavedLessonIdperiodId>(entity => {
                entity.HasKey(x => new {x.PeriodId, x.SavedLessonId});
                entity.ToTable("SavedLessonIDPeriodID");
                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
                entity.Property(e => e.SavedLessonId).HasColumnName("SavedLessonID");
            });

            modelBuilder.Entity<Teacher>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Name).IsRequired();
            });

            Block[] blocks = new Block[6];
            for (int i = 1; i < 7; i++) {
                blocks[i - 1] = new Block {Id = i, BlockNum = i};
            }
            string[] names = new[] {"13 SL Bio", "13 HL Bio Z1", "13 HL Bio Z2", "13 SL Che", "13 HL Che", "13 SL Phy", "13 HL Phy", "13 SL Comp", "13 HL Comp", "13 AI SL Mat", "13 AI SL/HL Mat", "13 AI HL Mat",
                "13 AA SL Mat 1", "13 AA SL Mat 2", "13 AA SL/HL Mat", "13 AA HL Mat", "13 SL Eng Lit 1", "13 HL Eng Lit 1", "13 HL Eng B 1", "13 HL Eng B 2", "22 SL Geog", "22 HL Geog", "22 SL His", "22 HL His",
                "22 SL Econ", "22 HL Econ", "22 SL S3B BUSMAN", "22 SL S3C BUSMAN", "22 HL S3B BUSMAN", "BTEC Y13", "PPS Y13", "22 SL 223S GloPo", "22 HL 223S GloPo", "22 SL 22S3 Psy", "22 HL 22S3 Psy", "FRE B 13 SL",
                "FRE AI SL", "SPA B 13 SL", "SPA B 13 HL", "SPA 13 LD", "13 SL SEHS", "13 HL SEHS", "GER LL 13Z1 SL", "GER LL 13Z2 SL", "GER LL 13 HL", "GER B 13 Z1 SL", "GER B 13 Z2 SL", "GER B 13 HL", "GER AI 13 Z1",
                "13 SL Visual Arts", "13 HL Visual Arts", "13 SL Theatre", "13 HL Theatre"};
            int[] years = new[] {13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13};
            int[] numLessons = new[] {6, 10, 10, 6, 4, 6, 4, 6, 4, 6, 6, 4, 6, 6, 6, 4, 6, 10, 10, 10, 6, 4, 6, 4, 6, 4, 6, 6, 4, 14, 4, 6, 4, 6, 4, 6, 6, 6, 4, 2, 6, 4, 6, 6, 4, 6, 6, 4, 6, 6, 4, 6, 4};
            string[] teacherNames = new[] {"S5", "S6", "S8", "S7", "S7", "S4", "S4", "C1", "C1", "M5", "M4", "M4", "M2", "M3", "M1", "M1", "E1", "E6", "E4", "E5", "H4", "H1", "H6", "H6", "H10", "H10", "H8", "H9", "H8",
                "H8", "H8", "H5", "H5", "H11", "H11", "L3", "L1", "L6", "L6", "L3", "P1", "P3", "G2", "G3", "G2", "G7", "G4", "G7", "G5", "A4", "A4", "A1", "A1"};
            List<int>[] options = new [] {new List<int> {4}, new List<int> {4}, new List<int> {4}, new List<int> {6}, new List<int> {6}, new List<int> {4}, new List<int> {4}, new List<int> {6}, new List<int> {6}, 
                new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {1}, new List<int> {1}, new List<int> {2}, new List<int> {6}, 
                new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {6}, new List<int> {3}, new List<int> {1, 4}, new List<int> {1, 4}, 
                new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {6}, new List<int> {6}, 
                new List<int> {1}, new List<int> {1}, new List<int> {1}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6}};
            string[] levels = new[] {"SL", "HL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "HL", "SL", "SL", "SL", "HL", "SL", "HL", "HL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "SL", "HL", "HL",
                "HL", "SL", "HL", "SL", "HL", "SL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "HL"};
            string[][] roomNums = new[] {new [] {"Gym 2", "0"}, new [] {"Hall", "1"}, new [] {"A0.11", "0"}, new [] {"N2.13", "2"}, new [] {"Art 2", "0"}, new [] {"Gym 3", "0"}, new [] {"N2.6", "2"}, new [] {"N2.27", "2"},
                new [] {"N2.16", "2"}, new [] {"A0.2", "0"}, new [] {"A1.3", "1"}, new [] {"N2.10", "2"}, new [] {"A1.2", "1"}, new [] {"N2.11", "2"}, new [] {"N0.40", "0"}, new [] {"N2.29", "2"}, new [] {"N2.20", "2"},
                new [] {"N2.17", "2"}, new [] {"N2.15", "2"}, new [] {"N2.2", "2"}, new [] {"N2.22", "2"}, new [] {"N2.12", "2"}, new [] {"A1.4", "1"}, new [] {"A1.6", "1"}, new [] {"N2.28", "2"}, new [] {"N2.14", "2"},
                new [] {"N0.41", "0"}, new [] {"A1.14", "1"}, new [] {"Gym 1", "0"}, new [] {"N2.18", "2"}, new [] {"N2.4", "2"}, new [] {"A1.13", "1"}, new [] {"N2.24", "2"}, new [] {"N2.25", "2"}, new [] {"Art 1", "0"},
                new [] {"N2.8", "2"}, new [] {"N2.30", "2"}, new [] {"A1.16", "1"}, new [] {"A1.15", "1"}, new [] {"A1.12", "1"}, new [] {"N2.23", "2"}, new [] {"1.13", "1"}, new [] {"1.12", "1"}};
            
            List<string> uniqueNames = new HashSet<string>(teacherNames).ToList();
            Lesson[] lessons = new Lesson[names.Length];
            for (int i = 0; i < names.Length; i++) {
                lessons[i] = new Lesson {
                    Name = names[i],
                    ClassCode = names[i],
                    Id = i + 1,
                    Level = levels[i],
                    NumLessons = numLessons[i],
                    TeacherId = uniqueNames.FindIndex(x=>x == teacherNames[i]) + 1,
                    Year = years[i]};
            }
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < uniqueNames.Count; i++) {
                teachers.Add(new Teacher {
                    Name = uniqueNames[i],
                    Id = i + 1 });
            }
            List<LessonIdblockId> lessonBlocks = new List<LessonIdblockId>();
            for (int i = 0; i < options.Length; i++) {
                foreach (int opt in options[i]) {
                    lessonBlocks.Add(new LessonIdblockId {
                        BlockId = opt,
                        LessonId = i + 1 });
                }
            }
            Room[] rooms = new Room[roomNums.Length];
            for (int i = 0; i < roomNums.Length; i++) {
                rooms[i] = new Room {
                    Number = roomNums[i][0],
                    Floor = int.Parse(roomNums[i][1]),
                    Id = i + 1 };
            }
            List<RoomIdlessonId> lessonRooms = new List<RoomIdlessonId>();
            for (int i = 1; i < names.Length; i++) {
                for (int j = 0; j < roomNums.Length; j++) {
                    if (roomNums[j][0][..3] == "Gym") continue;
                    lessonRooms.Add(new RoomIdlessonId {
                        RoomId = j + 1,
                        LessonId = i
                    });
                }
            }

            List<Period> periods = new List<Period>();
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 5; j++) {
                    for (int k = 1; k <= 7; k++) {
                        periods.Add(new Period {Id = k + j * 7 + i * 35, Week = i, Day = j, TimePeriod = k});
                    }
                }
            }
            
            modelBuilder.Entity<Block>().HasData(blocks);
            modelBuilder.Entity<Lesson>().HasData(lessons);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<LessonIdblockId>().HasData(lessonBlocks);
            modelBuilder.Entity<Room>().HasData(rooms);
            modelBuilder.Entity<RoomIdlessonId>().HasData(lessonRooms);
            modelBuilder.Entity<Period>().HasData(periods);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
