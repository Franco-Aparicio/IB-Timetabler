using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlite("Data Source = IB-Timetabler.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // modelBuilder.Entity<Block>(entity => {
            //     entity.Property(e => e.Id).HasColumnName("ID");
            //     entity.Property(e => e.Block1).HasColumnName("Block");
            // });
            //
            // modelBuilder.Entity<Lesson>(entity => {
            //     entity.Property(e => e.Id).HasColumnName("ID");
            //     entity.Property(e => e.ClassCode).IsRequired();
            //     entity.Property(e => e.Level).IsRequired();
            //     entity.Property(e => e.Name).IsRequired();
            //     entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            // });
            //
            // modelBuilder.Entity<LessonIdblockId>(entity => {
            //     entity.HasNoKey();
            //     entity.ToTable("LessonIDBlockID");
            //     entity.Property(e => e.BlockId).HasColumnName("BlockID");
            //     entity.Property(e => e.LessonId).HasColumnName("LessonID");
            // });
            //
            // modelBuilder.Entity<Period>(entity => {
            //     entity.Property(e => e.Id).HasColumnName("ID");
            // });
            //
            // modelBuilder.Entity<Room>(entity => {
            //     entity.Property(e => e.Id).HasColumnName("ID");
            //     entity.Property(e => e.Number).IsRequired();
            // });
            //
            // modelBuilder.Entity<RoomIdlessonId>(entity => {
            //     entity.HasNoKey();
            //     entity.ToTable("RoomIDLessonID");
            //     entity.Property(e => e.LessonId).HasColumnName("LessonID");
            //     entity.Property(e => e.RoomId).HasColumnName("RoomID");
            // });
            //
            // modelBuilder.Entity<Save>(entity => {
            //     entity.Property(e => e.Id).HasColumnName("ID");
            //     entity.Property(e => e.Name).IsRequired();
            // });
            //
            // modelBuilder.Entity<SavedLesson>(entity => {
            //     entity.HasNoKey();
            //     entity.Property(e => e.Lesson).IsRequired();
            //     entity.Property(e => e.Room).IsRequired();
            //     entity.Property(e => e.SaveId).HasColumnName("SaveID");
            //     entity.Property(e => e.Teacher).IsRequired();
            // });
            //
            // modelBuilder.Entity<SavedLessonIdperiodId>(entity => {
            //     entity.HasNoKey();
            //     entity.ToTable("SavedLessonIDPeriodID");
            //     entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
            //     entity.Property(e => e.SavedLessonId).HasColumnName("SavedLessonID");
            // });
            //
            // modelBuilder.Entity<Teacher>(entity => {
            //     entity.Property(e => e.Id).HasColumnName("ID");
            //     entity.Property(e => e.Name).IsRequired();
            // });

            Block[] blocks = new Block[6];
            for (int i = 1; i < 7; i++) {
                blocks[i] = new Block {Id = i, Block1 = i};
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
            string[] years = new[] {"12", "12", "12", "12", "12", "12", "12", "13", "13", "13", "13", "13", "13", "13", "12", "12", "13", "13", "12", "12", "12", "12", "12", "12", "13", "13", "13", "13", "13",
                "13", "13", "12", "12", "12", "12", "12", "12", "13", "13", "13", "13", "12", "12", "13", "13", "12", "12", "13", "13", "12", "12", "13", "13", "12", "12", "12", "12", "13", "13", "13", "12", "13",
                "12", "13", "12", "12", "13", "13", "12", "12", "13", "13", "12", "12", "13", "13", "12", "12", "12", "12", "13", "13", "13", "12", "12", "13", "13", "12", "12", "12", "13", "13", "13", "12", "12",
                "12", "12", "13", "13", "13", "13", "12", "12", "13", "13", "12", "12", "13", "13"};
            string[] numLesson = new[] {"6", "10", "10", "6", "4", "6", "4", "6", "10", "10", "6", "4", "6", "4", "6", "4", "6", "4", "6", "6", "4", "6", "6", "4", "6", "6", "4", "6", "6", "6", "4", "6", "6", "10",
                "10", "10", "10", "6", "10", "10", "10", "6", "4", "6", "4", "6", "4", "6", "4", "6", "4", "6", "4", "6", "4", "6", "4", "6", "6", "4", "14", "14", "4", "4", "6", "4", "6", "4", "6", "4", "6", "4",
                "6", "4", "6", "6", "6", "4", "2", "6", "6", "4", "2", "6", "4", "6", "4", "6", "6", "4", "6", "6", "4", "6", "6", "4", "6", "6", "6", "4", "6", "6", "4", "6", "4", "6", "4", "6", "4"};
            
            modelBuilder.Entity<Block>().HasData(blocks);
        }
    }
}
