using System.Collections.Generic;
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
        
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //     if (!optionsBuilder.IsConfigured) {
        //         optionsBuilder.UseSqlite("Data Source = IB-Timetabler.db");
        //     }
        // }

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
                entity.HasKey(x => new {x.Lesson, x.SaveId});
                entity.Property(e => e.Lesson).IsRequired();
                entity.Property(e => e.Room).IsRequired();
                entity.Property(e => e.SaveId).HasColumnName("SaveID");
                entity.Property(e => e.Teacher).IsRequired();
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
            string[] names = new[] {"12 SL Bio", "12 HL Bio Z1", "12 HL Bio Z2", "12 SL Che", "12 HL Che", "12 SL Phy", "12 HL Phy", "13 SL Bio", "13 HL Bio Z1", "13 HL Bio Z2", "13 SL Che", "13 HL Che",
                "13 SL Phy", "13 HL Phy", "12 SL Comp", "12 HL Comp", "13 SL Comp", "13 HL Comp", "12 AI SL Mat", "12 AI SL/HL Mat", "12 AI HL Mat", "12 AA SL Mat", "12 AA SL/HL Mat", "12 AA HL Mat",
                "13 AI SL Mat", "13 AI SL/HL Mat", "13 AI HL Mat", "13 AA SL Mat 1", "13 AA SL Mat 2", "13 AA SL/HL Mat", "13 AA HL Mat", "12 SL Eng Lang & Lit 1", "12 SL Eng Lang & Lit 2",
                "12 HL Eng Lang & Lit 3", "12 HL Eng B 1", "12 HL Eng B 2", "12 HL Eng B 3", "13 SL Eng Lit 1", "13 HL Eng Lit 1", "13 HL Eng B 1", "13 HL Eng B 2", "23 SL Geog", "23 HL Geog", "22 SL Geog",
                "22 HL Geog", "23 SL His", "23 HL His", "22 SL His", "22 HL His", "23 SL Econ", "23 HL Econ", "22 SL Econ", "22 HL Econ", "23 SL A BUSMAN", "23 HL A BUSMAN", "23 SL B BUSMAN", "23 HL B BUSMAN",
                "22 SL S3B BUSMAN", "22 SL S3C BUSMAN", "22 HL S3B BUSMAN", "BTEC Y12", "BTEC Y13", "PPS Y12", "PPS Y13", "23 SL GloPo", "23 HL GloPo", "22 SL 223S GloPo", "22 HL 223S GloPo", "23 SL Psy",
                "23 HL Psy", "22 SL 22S3 Psy", "22 HL 22S3 Psy", "FRE B 12 SL", "FRE B 12 HL", "FRE B 13 SL", "FRE AI SL", "SPA B 12 SL", "SPA B 12 HL", "SPA 12 LD", "SPA 12 AI SL", "SPA B 13 SL", "SPA B 13 HL",
                "SPA 13 LD", "12 SL SEHS", "12 HL SEHS", "13 SL SEHS", "13 HL SEHS", "GER LL 12Z1 SL", "GER LL 12Z2 SL", "GER LL 12 HL", "GER LL 13Z1 SL", "GER LL 13Z2 SL", "GER LL 13 HL", "GER B 12 Z1 SL",
                "GER B 12 Z2 SL", "GER B 12 HL", "GER AI 12 Z1", "GER B 13 Z1 SL", "GER B 13 Z2 SL", "GER B 13 HL", "GER AI 13 Z1", "12 SL Visual Arts", "12 HL Visual Arts", "13 SL Visual Arts",
                "13 HL Visual Arts", "12 SL Theatre", "12 HL Theatre", "13 SL Theatre", "13 HL Theatre"};
            int[] years = new[] {12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 12, 12, 13, 13, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 12, 12, 13,
                13, 12, 12, 13, 13, 12, 12, 13, 13, 12, 12, 12, 12, 13, 13, 13, 12, 13, 12, 13, 12, 12, 13, 13, 12, 12, 13, 13, 12, 12, 13, 13, 12, 12, 12, 12, 13, 13, 13, 12, 12, 13, 13, 12, 12, 12, 13, 13,
                13, 12, 12, 12, 12, 13, 13, 13, 13, 12, 12, 13, 13, 12, 12, 13, 13};
            int[] numLessons = new[] {6, 10, 10, 6, 4, 6, 4, 6, 10, 10, 6, 4, 6, 4, 6, 4, 6, 4, 6, 6, 4, 6, 6, 4, 6, 6, 4, 6, 6, 6, 4, 6, 6, 10, 10, 10, 10, 6, 10, 10, 10, 6, 4, 6, 4, 6, 4, 6, 4, 6, 4, 6, 4, 6,
                4, 6, 4, 6, 6, 4, 14, 14, 4, 4, 6, 4, 6, 4, 6, 4, 6, 4, 6, 4, 6, 6, 6, 4, 2, 6, 6, 4, 2, 6, 4, 6, 4, 6, 6, 4, 6, 6, 4, 6, 6, 4, 6, 6, 6, 4, 6, 6, 4, 6, 4, 6, 4, 6, 4};
            string[] teacherNames = new[] {"S8", "S1", "S3", "S2", "S2", "S4", "S4", "S5", "S6", "S8", "S7", "S7", "S4", "S4", "C1", "C1", "C1", "C1", "M6", "M4", "M4", "M1", "M2", "M2", "M5", "M4", "M4", "M2", "M3",
                "M1", "M1", "E3", "E5", "E1", "E7", "E2", "E4", "E1", "E6", "E4", "E5", "H2", "H2", "H4", "H1", "H7", "H5", "H6", "H6", "H10", "H10", "H10", "H10", "H8", "H8", "H10", "H9", "H8", "H9", "H8", "H9",
                "H8", "H9", "H8", "H1", "H1", "H5", "H5", "H12", "H12", "H11", "H11", "L1", "L3", "L3", "L1", "L6", "L6", "L3", "L5", "L6", "L6", "L3", "P2", "P3", "P1", "P3", "G2", "G3", "G2", "G2", "G3", "G2",
                "G7", "G4", "G7", "G8", "G7", "G4", "G7", "G5", "A3", "A3", "A4", "A4", "A1", "A1", "A1", "A1"};
            List<int>[] options = new [] {new List<int> {4}, new List<int> {4}, new List<int> {4}, new List<int> {6}, new List<int> {6}, new List<int> {4}, new List<int> {4}, new List<int> {4}, new List<int> {4},
                new List<int> {4}, new List<int> {6}, new List<int> {6}, new List<int> {4}, new List<int> {4}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {5},
                new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5}, new List<int> {5},
                new List<int> {5}, new List<int> {5}, new List<int> {1}, new List<int> {1}, new List<int> {1}, new List<int> {2}, new List<int> {2}, new List<int> {6}, new List<int> {1}, new List<int> {1},
                new List<int> {2}, new List<int> {6}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3},
                new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {6}, new List<int> {6}, new List<int> {3}, new List<int> {6},
                new List<int> {3}, new List<int> {1, 4}, new List<int> {1, 4}, new List<int> {1, 4}, new List<int> {1, 4}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3},
                new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {3}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2},
                new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {1},
                new List<int> {1}, new List<int> {1}, new List<int> {1}, new List<int> {1}, new List<int> {1}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {2},
                new List<int> {2}, new List<int> {2}, new List<int> {2}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6}, new List<int> {6},
                new List<int> {6}};
            string[] levels = new[] {"SL", "HL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "HL", "SL", "HL", "HL", "SL", "HL", "HL", "SL", "SL",
                "SL", "HL", "SL", "SL", "HL", "HL", "HL", "HL", "SL", "HL", "HL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "SL", "HL", "HL", "HL",
                "HL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "SL", "SL", "HL", "HL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "HL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "SL",
                "HL", "SL", "SL", "SL", "HL", "SL", "SL", "HL", "SL", "HL", "SL", "HL", "SL", "HL"};
            string[][] roomNums = new[] {new [] {"Gym 2", "0"}, new [] {"Hall", "1"}, new [] {"A0.11", "0"}, new [] {"N2.13", "2"}, new [] {"Art 2", "0"}, new [] {"Gym 3", "0"}, new [] {"N2.6", "2"}, new [] {"N2.27", "2"},
                new [] {"N2.16", "2"}, new [] {"A0.2", "0"}, new [] {"A1.3", "1"}, new [] {"N2.10", "2"}, new [] {"A1.2", "1"}, new [] {"N2.11", "2"}, new [] {"N0.40", "0"}, new [] {"N2.29", "2"}, new [] {"N2.20", "2"},
                new [] {"N2.17", "2"}, new [] {"N2.15", "2"}, new [] {"N2.2", "2"}, new [] {"N2.22", "2"}, new [] {"N2.12", "2"}, new [] {"A1.4", "1"}, new [] {"A1.6", "1"}, new [] {"N2.28", "2"}, new [] {"N2.14", "2"},
                new [] {"N0.41", "0"}, new [] {"A1.14", "1"}, new [] {"Gym 1", "0"}, new [] {"N2.18", "2"}, new [] {"N2.4", "2"}, new [] {"A1.13", "1"}, new [] {"N2.24", "2"}, new [] {"N2.25", "2"}, new [] {"Art 1", "0"},
                new [] {"N2.8", "2"}, new [] {"N2.30", "2"}, new [] {"A1.16", "1"}, new [] {"A1.15", "1"}, new [] {"A1.12", "1"}, new [] {"N2.23", "2"}, new [] {"1.13", "1"}, new [] {"1.12", "1"}};
            
            Lesson[] lessons = new Lesson[names.Length];
            for (int i = 0; i < names.Length; i++) {
                lessons[i] = new Lesson {
                    Name = names[i],
                    ClassCode = names[i],
                    Id = i + 1,
                    Level = levels[i],
                    NumLessons = numLessons[i],
                    TeacherId = i + 1,
                    Year = years[i]};
            }
            Teacher[] teachers = new Teacher[teacherNames.Length];
            for (int i = 0; i < teacherNames.Length; i++) {
                teachers[i] = new Teacher {
                    Name = teacherNames[i],
                    Id = i + 1 };
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
            for (int i = 0; i < options.Length; i++) {
                foreach (int opt in options[i]) {
                    lessonRooms.Add(new RoomIdlessonId {
                        RoomId = opt,
                        LessonId = i + 1 });
                }
            }
            
            modelBuilder.Entity<Block>().HasData(blocks);
            modelBuilder.Entity<Lesson>().HasData(lessons);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<LessonIdblockId>().HasData(lessonBlocks);
            modelBuilder.Entity<Room>().HasData(rooms);
            modelBuilder.Entity<RoomIdlessonId>().HasData(lessonRooms);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
