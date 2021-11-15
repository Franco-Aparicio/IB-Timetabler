using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IB_Timetabler.Data {

    public class LessonDbContext : DbContext {
        
        public LessonDbContext(DbContextOptions<LessonDbContext> options) :base(options) {}
        
        public DbSet<Lesson> Lesson { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Lesson>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private List<Lesson> GetProducts() {
            return new List<Lesson>() {
                new Lesson {
                    ClassCode = "1",
                    Name = "Math AA HL",
                    Year = 13,
                    NumLessons = 4,
                    Teacher = "M1",
                    Blocks = new [] {5},
                    Level = "HL",
                    Rooms = new List<string> {
                        "N 0.4", "A 1.4", "A 1.6"
                    }
                },
                new Lesson {
                    ClassCode = "2",
                    Name = "Math AA SL",
                    Year = 13,
                    NumLessons = 4,
                    Teacher = "M1",
                    Blocks = new [] {5},
                    Level = "SL",
                    Rooms = new List<string> {
                        "N 0.4", "A 1.4", "A 1.6"
                    }
                },
                new Lesson {
                    ClassCode = "3",
                    Name = "Math AI HL",
                    Year = 13,
                    NumLessons = 4,
                    Teacher = "M2",
                    Blocks = new [] {5},
                    Level = "HL",
                    Rooms = new List<string> {
                        "N 0.4", "A 1.4", "A 1.6"
                    }
                },
                new Lesson {
                    ClassCode = "4",
                    Name = "Math AI SL",
                    Year = 13,
                    NumLessons = 4,
                    Teacher = "M2",
                    Blocks = new [] {5},
                    Level = "SL",
                    Rooms = new List<string> {
                        "N 0.4", "A 1.4", "A 1.6"
                    }
                }
            };
        }
    }
}