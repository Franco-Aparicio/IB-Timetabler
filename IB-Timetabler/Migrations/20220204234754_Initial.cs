using Microsoft.EntityFrameworkCore.Migrations;

namespace IB_Timetabler.Migrations {
    
    public partial class Initial : Migration {
        
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(name: "Blocks",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Block = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_Blocks", x => x.ID); });

            migrationBuilder.CreateTable(name: "LessonIDBlockID",
                columns: table => new {
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    BlockID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_LessonIDBlockID", x => new { x.BlockID, x.LessonID }); });

            migrationBuilder.CreateTable(name: "Lessons",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<long>(type: "INTEGER", nullable: false),
                    Level = table.Column<string>(type: "TEXT", nullable: false),
                    ClassCode = table.Column<string>(type: "TEXT", nullable: false),
                    NumLessons = table.Column<long>(type: "INTEGER", nullable: false),
                    TeacherID = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_Lessons", x => x.ID); });

            migrationBuilder.CreateTable(name: "Periods",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Week = table.Column<long>(type: "INTEGER", nullable: false),
                    Day = table.Column<long>(type: "INTEGER", nullable: false),
                    TimePeriod = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_Periods", x => x.ID); });

            migrationBuilder.CreateTable(name: "RoomIDLessonID",
                columns: table => new {
                    RoomID = table.Column<long>(type: "INTEGER", nullable: false),
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_RoomIDLessonID", x => new { x.LessonID, x.RoomID }); });

            migrationBuilder.CreateTable(name: "Rooms",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Floor = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_Rooms", x => x.ID); });

            migrationBuilder.CreateTable(name: "SavedLessonIDPeriodID",
                columns: table => new {
                    SavedLessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    PeriodID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_SavedLessonIDPeriodID", x => new { x.PeriodID, x.SavedLessonID });
                });

            migrationBuilder.CreateTable(name: "SavedLessons",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    SaveID = table.Column<long>(type: "INTEGER", nullable: false),
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    RoomID = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_SavedLessons", x => x.ID); });

            migrationBuilder.CreateTable(name: "Saves",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_Saves", x => x.ID); });

            migrationBuilder.CreateTable(name: "Teachers",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_Teachers", x => x.ID); });

            migrationBuilder.InsertData(table: "Blocks", columns: new[] { "ID", "Block" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(table: "Blocks", columns: new[] { "ID", "Block" },
                values: new object[] { 2L, 2L });

            migrationBuilder.InsertData(table: "Blocks", columns: new[] { "ID", "Block" },
                values: new object[] { 3L, 3L });

            migrationBuilder.InsertData(table: "Blocks", columns: new[] { "ID", "Block" },
                values: new object[] { 4L, 4L });

            migrationBuilder.InsertData(table: "Blocks", columns: new[] { "ID", "Block" },
                values: new object[] { 5L, 5L });

            migrationBuilder.InsertData(table: "Blocks", columns: new[] { "ID", "Block" },
                values: new object[] { 6L, 6L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 19L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 20L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 21L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 22L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 25L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 24L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 18L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 26L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 27L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 23L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 17L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 13L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 14L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 28L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 12L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 11L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 10L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 9L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 8L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 7L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 6L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 5L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 4L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 16L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 29L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 31L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 30L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 53L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 52L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 51L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 50L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 49L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 48L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 47L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 46L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 45L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 44L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 43L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 30L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 42L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 40L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 39L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 38L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 37L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 36L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 35L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 34L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 33L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 32L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 31L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 3L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 41L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 2L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 15L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 1L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 53L, "13 HL Theatre", "HL", "13 HL Theatre", 4L, 35L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 24L, "22 HL His", "HL", "22 HL His", 4L, 18L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 23L, "22 SL His", "SL", "22 SL His", 6L, 18L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 22L, "22 HL Geog", "HL", "22 HL Geog", 4L, 17L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 21L, "22 SL Geog", "SL", "22 SL Geog", 6L, 16L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 20L, "13 HL Eng B 2", "HL", "13 HL Eng B 2", 10L, 15L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 19L, "13 HL Eng B 1", "HL", "13 HL Eng B 1", 10L, 14L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 18L, "13 HL Eng Lit 1", "HL", "13 HL Eng Lit 1", 10L, 13L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 17L, "13 SL Eng Lit 1", "SL", "13 SL Eng Lit 1", 6L, 12L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 16L, "13 AA HL Mat", "HL", "13 AA HL Mat", 4L, 11L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 15L, "13 AA SL/HL Mat", "SL", "13 AA SL/HL Mat", 6L, 11L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 14L, "13 AA SL Mat 2", "SL", "13 AA SL Mat 2", 6L, 10L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 13L, "13 AA SL Mat 1", "SL", "13 AA SL Mat 1", 6L, 9L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 12L, "13 AI HL Mat", "HL", "13 AI HL Mat", 4L, 8L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 10L, "13 AI SL Mat", "SL", "13 AI SL Mat", 6L, 7L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 9L, "13 HL Comp", "HL", "13 HL Comp", 4L, 6L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 8L, "13 SL Comp", "SL", "13 SL Comp", 6L, 6L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 7L, "13 HL Phy", "HL", "13 HL Phy", 4L, 5L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 6L, "13 SL Phy", "SL", "13 SL Phy", 6L, 5L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 5L, "13 HL Che", "HL", "13 HL Che", 4L, 4L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 4L, "13 SL Che", "SL", "13 SL Che", 6L, 4L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 3L, "13 HL Bio Z2", "HL", "13 HL Bio Z2", 10L, 3L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 2L, "13 HL Bio Z1", "HL", "13 HL Bio Z1", 10L, 2L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 1L, "13 SL Bio", "SL", "13 SL Bio", 6L, 1L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 25L, "22 SL Econ", "SL", "22 SL Econ", 6L, 19L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 26L, "22 HL Econ", "HL", "22 HL Econ", 4L, 19L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 11L, "13 AI SL/HL Mat", "HL", "13 AI SL/HL Mat", 6L, 8L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 28L, "22 SL S3C BUSMAN", "SL", "22 SL S3C BUSMAN", 6L, 21L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 27L, "22 SL S3B BUSMAN", "SL", "22 SL S3B BUSMAN", 6L, 20L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 52L, "13 SL Theatre", "SL", "13 SL Theatre", 6L, 35L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 51L, "13 HL Visual Arts", "HL", "13 HL Visual Arts", 4L, 34L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 50L, "13 SL Visual Arts", "SL", "13 SL Visual Arts", 6L, 34L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 49L, "GER AI 13 Z1", "SL", "GER AI 13 Z1", 6L, 33L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 48L, "GER B 13 HL", "HL", "GER B 13 HL", 4L, 31L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 46L, "GER B 13 Z1 SL", "SL", "GER B 13 Z1 SL", 6L, 31L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 45L, "GER LL 13 HL", "HL", "GER LL 13 HL", 4L, 29L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 44L, "GER LL 13Z2 SL", "SL", "GER LL 13Z2 SL", 6L, 30L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 43L, "GER LL 13Z1 SL", "SL", "GER LL 13Z1 SL", 6L, 29L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 42L, "13 HL SEHS", "HL", "13 HL SEHS", 4L, 28L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 41L, "13 SL SEHS", "SL", "13 SL SEHS", 6L, 27L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 47L, "GER B 13 Z2 SL", "SL", "GER B 13 Z2 SL", 6L, 32L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 40L, "SPA 13 LD", "SL", "SPA 13 LD", 2L, 24L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 29L, "22 HL S3B BUSMAN", "HL", "22 HL S3B BUSMAN", 4L, 20L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 30L, "BTEC Y13", "HL", "BTEC Y13", 14L, 20L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 31L, "PPS Y13", "HL", "PPS Y13", 4L, 20L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 33L, "22 HL 223S GloPo", "HL", "22 HL 223S GloPo", 4L, 22L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 34L, "22 SL 22S3 Psy", "SL", "22 SL 22S3 Psy", 6L, 23L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 32L, "22 SL 223S GloPo", "SL", "22 SL 223S GloPo", 6L, 22L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 35L, "22 HL 22S3 Psy", "HL", "22 HL 22S3 Psy", 4L, 23L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 36L, "FRE B 13 SL", "SL", "FRE B 13 SL", 6L, 24L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 37L, "FRE AI SL", "SL", "FRE AI SL", 6L, 25L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 38L, "SPA B 13 SL", "SL", "SPA B 13 SL", 6L, 26L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 39L, "SPA B 13 HL", "HL", "SPA B 13 HL", 4L, 26L, 13L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 47L, 1L, 5L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 51L, 2L, 2L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 50L, 2L, 1L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 49L, 1L, 7L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 48L, 1L, 6L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 52L, 2L, 3L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 46L, 1L, 4L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 40L, 0L, 5L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 44L, 1L, 2L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 42L, 0L, 7L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 41L, 0L, 6L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 38L, 0L, 3L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 39L, 0L, 4L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 53L, 2L, 4L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 45L, 1L, 3L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 54L, 2L, 5L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 67L, 4L, 4L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 56L, 2L, 7L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 37L, 0L, 2L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 70L, 4L, 7L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 69L, 4L, 6L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 68L, 4L, 5L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 66L, 4L, 3L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 65L, 4L, 2L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 55L, 2L, 6L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 64L, 4L, 1L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 62L, 3L, 6L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 61L, 3L, 5L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 60L, 3L, 4L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 59L, 3L, 3L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 58L, 3L, 2L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 57L, 3L, 1L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 63L, 3L, 7L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 36L, 0L, 1L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 43L, 1L, 1L, 1L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 34L, 4L, 6L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 15L, 2L, 1L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 14L, 1L, 7L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 13L, 1L, 6L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 12L, 1L, 5L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 11L, 1L, 4L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 10L, 1L, 3L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 9L, 1L, 2L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 8L, 1L, 1L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 7L, 0L, 7L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 6L, 0L, 6L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 5L, 0L, 5L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 4L, 0L, 4L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 2L, 0L, 2L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 1L, 0L, 1L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 35L, 4L, 7L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 16L, 2L, 2L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 17L, 2L, 3L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 3L, 0L, 3L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 19L, 2L, 5L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 18L, 2L, 4L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 32L, 4L, 4L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 30L, 4L, 2L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 29L, 4L, 1L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 28L, 3L, 7L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 27L, 3L, 6L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 31L, 4L, 3L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 25L, 3L, 4L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 20L, 2L, 6L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 26L, 3L, 5L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 21L, 2L, 7L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 33L, 4L, 5L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 23L, 3L, 2L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 24L, 3L, 3L, 0L });

            migrationBuilder.InsertData(table: "Periods", columns: new[] { "ID", "Day", "TimePeriod", "Week" },
                values: new object[] { 22L, 3L, 1L, 0L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 40L });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 18L, 2L, "N2.17" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 19L, 2L, "N2.15" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 17L, 2L, "N2.20" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 16L, 2L, "N2.29" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 15L, 0L, "N0.40" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 14L, 2L, "N2.11" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 13L, 1L, "A1.2" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 12L, 2L, "N2.10" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 11L, 1L, "A1.3" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 5L, 0L, "Art 2" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 9L, 2L, "N2.16" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 8L, 2L, "N2.27" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 7L, 2L, "N2.6" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 6L, 0L, "Gym 3" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 4L, 2L, "N2.13" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 3L, 0L, "A0.11" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 2L, 1L, "Hall" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 20L, 2L, "N2.2" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 1L, 0L, "Gym 2" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 10L, 0L, "A0.2" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 21L, 2L, "N2.22" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 36L, 2L, "N2.8" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 23L, 1L, "A1.4" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 22L, 2L, "N2.12" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 43L, 1L, "1.12" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 41L, 2L, "N2.23" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 40L, 1L, "A1.12" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 39L, 1L, "A1.15" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 38L, 1L, "A1.16" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 37L, 2L, "N2.30" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 35L, 0L, "Art 1" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 34L, 2L, "N2.25" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 42L, 1L, "1.13" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 32L, 1L, "A1.13" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 33L, 2L, "N2.24" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 26L, 2L, "N2.14" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 27L, 0L, "N0.41" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 25L, 2L, "N2.28" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 29L, 0L, "Gym 1" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 30L, 2L, "N2.18" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 31L, 2L, "N2.4" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 28L, 1L, "A1.14" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 24L, 1L, "A1.6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 20L, "H8" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 26L, "L6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 21L, "H9" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 22L, "H5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 23L, "H11" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 24L, "L3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 25L, "L1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 30L, "G3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 28L, "P3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 29L, "G2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 31L, "G7" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 32L, "G4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 33L, "G5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 19L, "H10" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 27L, "P1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 18L, "H6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 7L, "M5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 16L, "H4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 34L, "A4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 1L, "S5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 2L, "S6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 3L, "S8" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 4L, "S7" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 5L, "S4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 6L, "C1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 8L, "M4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 9L, "M2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 10L, "M3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 11L, "M1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 12L, "E1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 13L, "E6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 14L, "E4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 15L, "E5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 17L, "H1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 35L, "A1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(name: "Blocks");

            migrationBuilder.DropTable(name: "LessonIDBlockID");

            migrationBuilder.DropTable(name: "Lessons");

            migrationBuilder.DropTable(name: "Periods");

            migrationBuilder.DropTable(name: "RoomIDLessonID");

            migrationBuilder.DropTable(name: "Rooms");

            migrationBuilder.DropTable(name: "SavedLessonIDPeriodID");

            migrationBuilder.DropTable(name: "SavedLessons");

            migrationBuilder.DropTable(name: "Saves");

            migrationBuilder.DropTable(name: "Teachers");
        }
    }
}