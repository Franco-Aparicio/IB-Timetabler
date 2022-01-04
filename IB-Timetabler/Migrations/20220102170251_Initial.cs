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
                    ID = table.Column<long>(type: "INTEGER", nullable: false),
                    SaveID = table.Column<long>(type: "INTEGER", nullable: false),
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    RoomID = table.Column<long>(type: "INTEGER", nullable: false)
                }, constraints: table => { table.PrimaryKey("PK_SavedLessons", x => new { x.ID }); });

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
                values: new object[] { 3L, 42L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 41L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 40L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 39L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 38L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 35L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 36L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 43L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 34L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 33L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 37L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 44L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 47L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 46L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 32L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 48L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 49L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 50L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 51L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 52L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 53L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 54L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 55L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 56L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 45L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 31L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 28L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 29L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 5L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 6L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 7L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 8L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 9L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 10L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 11L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 12L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 13L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 14L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 15L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 30L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 16L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 18L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 19L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 20L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 21L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 22L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 23L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 24L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 25L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 26L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 27L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 57L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 17L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 58L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 61L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 60L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 86L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 87L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 88L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 89L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 90L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 91L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 92L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 93L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 94L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 95L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 96L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 85L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 97L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 99L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 100L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 101L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 102L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 103L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 104L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 105L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 106L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 107L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 108L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 109L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 98L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 59L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 84L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 82L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 4L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 61L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 62L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 62L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 63L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 64L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 64L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 65L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 66L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 67L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 68L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 83L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 69L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 71L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 72L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 73L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 74L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 75L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 76L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 77L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 78L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 79L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 80L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 81L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 70L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 3L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 63L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 1L });

            migrationBuilder.InsertData(table: "LessonIDBlockID", columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 2L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 30L, "13 AA SL/HL Mat", "SL", "13 AA SL/HL Mat", 6L, 12L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 31L, "13 AA HL Mat", "HL", "13 AA HL Mat", 4L, 12L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 32L, "12 SL Eng Lang & Lit 1", "SL", "12 SL Eng Lang & Lit 1", 6L, 16L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 33L, "12 SL Eng Lang & Lit 2", "SL", "12 SL Eng Lang & Lit 2", 6L, 17L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 34L, "12 HL Eng Lang & Lit 3", "HL", "12 HL Eng Lang & Lit 3", 10L, 18L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 35L, "12 HL Eng B 1", "HL", "12 HL Eng B 1", 10L, 19L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 36L, "12 HL Eng B 2", "HL", "12 HL Eng B 2", 10L, 20L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 37L, "12 HL Eng B 3", "HL", "12 HL Eng B 3", 10L, 21L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 38L, "13 SL Eng Lit 1", "SL", "13 SL Eng Lit 1", 6L, 18L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 39L, "13 HL Eng Lit 1", "HL", "13 HL Eng Lit 1", 10L, 22L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 40L, "13 HL Eng B 1", "HL", "13 HL Eng B 1", 10L, 21L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 41L, "13 HL Eng B 2", "HL", "13 HL Eng B 2", 10L, 17L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 42L, "23 SL Geog", "SL", "23 SL Geog", 6L, 23L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 43L, "23 HL Geog", "HL", "23 HL Geog", 4L, 23L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 44L, "22 SL Geog", "SL", "22 SL Geog", 6L, 24L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 45L, "22 HL Geog", "HL", "22 HL Geog", 4L, 25L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 46L, "23 SL His", "SL", "23 SL His", 6L, 26L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 47L, "23 HL His", "HL", "23 HL His", 4L, 27L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 48L, "22 SL His", "SL", "22 SL His", 6L, 28L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 49L, "22 HL His", "HL", "22 HL His", 4L, 28L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 50L, "23 SL Econ", "SL", "23 SL Econ", 6L, 29L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 51L, "23 HL Econ", "HL", "23 HL Econ", 4L, 29L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 52L, "22 SL Econ", "SL", "22 SL Econ", 6L, 29L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 29L, "13 AA SL Mat 2", "SL", "13 AA SL Mat 2", 6L, 15L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 28L, "13 AA SL Mat 1", "SL", "13 AA SL Mat 1", 6L, 13L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 27L, "13 AI HL Mat", "HL", "13 AI HL Mat", 4L, 11L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 26L, "13 AI SL/HL Mat", "HL", "13 AI SL/HL Mat", 6L, 11L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 1L, "12 SL Bio", "SL", "12 SL Bio", 6L, 1L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 2L, "12 HL Bio Z1", "HL", "12 HL Bio Z1", 10L, 2L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 3L, "12 HL Bio Z2", "HL", "12 HL Bio Z2", 10L, 3L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 4L, "12 SL Che", "SL", "12 SL Che", 6L, 4L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 5L, "12 HL Che", "HL", "12 HL Che", 4L, 4L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 6L, "12 SL Phy", "SL", "12 SL Phy", 6L, 5L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 7L, "12 HL Phy", "HL", "12 HL Phy", 4L, 5L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 8L, "13 SL Bio", "SL", "13 SL Bio", 6L, 6L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 9L, "13 HL Bio Z1", "HL", "13 HL Bio Z1", 10L, 7L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 10L, "13 HL Bio Z2", "HL", "13 HL Bio Z2", 10L, 1L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 11L, "13 SL Che", "SL", "13 SL Che", 6L, 8L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 53L, "22 HL Econ", "HL", "22 HL Econ", 4L, 29L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 12L, "13 HL Che", "HL", "13 HL Che", 4L, 8L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 14L, "13 HL Phy", "HL", "13 HL Phy", 4L, 5L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 15L, "12 SL Comp", "SL", "12 SL Comp", 6L, 9L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 16L, "12 HL Comp", "HL", "12 HL Comp", 4L, 9L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 17L, "13 SL Comp", "SL", "13 SL Comp", 6L, 9L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 18L, "13 HL Comp", "HL", "13 HL Comp", 4L, 9L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 19L, "12 AI SL Mat", "SL", "12 AI SL Mat", 6L, 10L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 20L, "12 AI SL/HL Mat", "HL", "12 AI SL/HL Mat", 6L, 11L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 21L, "12 AI HL Mat", "HL", "12 AI HL Mat", 4L, 11L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 22L, "12 AA SL Mat", "SL", "12 AA SL Mat", 6L, 12L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 24L, "12 AA HL Mat", "HL", "12 AA HL Mat", 4L, 13L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 25L, "13 AI SL Mat", "SL", "13 AI SL Mat", 6L, 14L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 13L, "13 SL Phy", "SL", "13 SL Phy", 6L, 5L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 54L, "23 SL A BUSMAN", "SL", "23 SL A BUSMAN", 6L, 30L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 23L, "12 AA SL/HL Mat", "HL", "12 AA SL/HL Mat", 6L, 13L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 56L, "23 SL B BUSMAN", "SL", "23 SL B BUSMAN", 6L, 29L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 85L, "12 HL SEHS", "HL", "12 HL SEHS", 4L, 39L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 86L, "13 SL SEHS", "SL", "13 SL SEHS", 6L, 40L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 87L, "13 HL SEHS", "HL", "13 HL SEHS", 4L, 39L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 88L, "GER LL 12Z1 SL", "SL", "GER LL 12Z1 SL", 6L, 41L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 89L, "GER LL 12Z2 SL", "SL", "GER LL 12Z2 SL", 6L, 42L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 90L, "GER LL 12 HL", "HL", "GER LL 12 HL", 4L, 41L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 91L, "GER LL 13Z1 SL", "SL", "GER LL 13Z1 SL", 6L, 41L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 92L, "GER LL 13Z2 SL", "SL", "GER LL 13Z2 SL", 6L, 42L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 93L, "GER LL 13 HL", "HL", "GER LL 13 HL", 4L, 41L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 94L, "GER B 12 Z1 SL", "SL", "GER B 12 Z1 SL", 6L, 43L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 95L, "GER B 12 Z2 SL", "SL", "GER B 12 Z2 SL", 6L, 44L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 96L, "GER B 12 HL", "HL", "GER B 12 HL", 4L, 43L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 98L, "GER B 13 Z1 SL", "SL", "GER B 13 Z1 SL", 6L, 43L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 99L, "GER B 13 Z2 SL", "SL", "GER B 13 Z2 SL", 6L, 44L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 100L, "GER B 13 HL", "HL", "GER B 13 HL", 4L, 43L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 101L, "GER AI 13 Z1", "SL", "GER AI 13 Z1", 6L, 46L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 102L, "12 SL Visual Arts", "SL", "12 SL Visual Arts", 6L, 47L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 103L, "12 HL Visual Arts", "HL", "12 HL Visual Arts", 4L, 47L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 104L, "13 SL Visual Arts", "SL", "13 SL Visual Arts", 6L, 48L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 105L, "13 HL Visual Arts", "HL", "13 HL Visual Arts", 4L, 48L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 106L, "12 SL Theatre", "SL", "12 SL Theatre", 6L, 49L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 107L, "12 HL Theatre", "HL", "12 HL Theatre", 4L, 49L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 108L, "13 SL Theatre", "SL", "13 SL Theatre", 6L, 49L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 55L, "23 HL A BUSMAN", "HL", "23 HL A BUSMAN", 4L, 30L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 109L, "13 HL Theatre", "HL", "13 HL Theatre", 4L, 49L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 84L, "12 SL SEHS", "SL", "12 SL SEHS", 6L, 38L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 83L, "SPA 13 LD", "SL", "SPA 13 LD", 2L, 35L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 97L, "GER AI 12 Z1", "SL", "GER AI 12 Z1", 6L, 45L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 81L, "SPA B 13 SL", "SL", "SPA B 13 SL", 6L, 36L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 57L, "23 HL B BUSMAN", "HL", "23 HL B BUSMAN", 4L, 31L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 58L, "22 SL S3B BUSMAN", "SL", "22 SL S3B BUSMAN", 6L, 30L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 82L, "SPA B 13 HL", "HL", "SPA B 13 HL", 4L, 36L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 59L, "22 SL S3C BUSMAN", "SL", "22 SL S3C BUSMAN", 6L, 31L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 60L, "22 HL S3B BUSMAN", "HL", "22 HL S3B BUSMAN", 4L, 30L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 61L, "BTEC Y12", "HL", "BTEC Y12", 14L, 31L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 62L, "BTEC Y13", "HL", "BTEC Y13", 14L, 30L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 64L, "PPS Y13", "HL", "PPS Y13", 4L, 30L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 65L, "23 SL GloPo", "SL", "23 SL GloPo", 6L, 25L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 66L, "23 HL GloPo", "HL", "23 HL GloPo", 4L, 25L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 67L, "22 SL 223S GloPo", "SL", "22 SL 223S GloPo", 6L, 27L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 68L, "22 HL 223S GloPo", "HL", "22 HL 223S GloPo", 4L, 27L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 63L, "PPS Y12", "HL", "PPS Y12", 4L, 31L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 75L, "FRE B 13 SL", "SL", "FRE B 13 SL", 6L, 35L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 69L, "23 SL Psy", "SL", "23 SL Psy", 6L, 32L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 78L, "SPA B 12 HL", "HL", "SPA B 12 HL", 4L, 36L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 77L, "SPA B 12 SL", "SL", "SPA B 12 SL", 6L, 36L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 76L, "FRE AI SL", "SL", "FRE AI SL", 6L, 34L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 80L, "SPA 12 AI SL", "SL", "SPA 12 AI SL", 6L, 37L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 79L, "SPA 12 LD", "HL", "SPA 12 LD", 2L, 35L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 74L, "FRE B 12 HL", "HL", "FRE B 12 HL", 4L, 35L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 73L, "FRE B 12 SL", "SL", "FRE B 12 SL", 6L, 34L, 12L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 72L, "22 HL 22S3 Psy", "HL", "22 HL 22S3 Psy", 4L, 33L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 71L, "22 SL 22S3 Psy", "SL", "22 SL 22S3 Psy", 6L, 33L, 13L });

            migrationBuilder.InsertData(table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 70L, "23 HL Psy", "HL", "23 HL Psy", 4L, 32L, 12L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 1L, 0L, 0L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 2L, 0L, 0L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 3L, 0L, 0L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 4L, 0L, 0L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 5L, 0L, 0L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 6L, 0L, 0L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 7L, 0L, 0L, 7L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 8L, 0L, 1L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 9L, 0L, 1L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 10L, 0L, 1L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 11L, 0L, 1L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 12L, 0L, 1L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 13L, 0L, 1L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 14L, 0L, 1L, 7L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 15L, 0L, 2L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 16L, 0L, 2L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 17L, 0L, 2L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 18L, 0L, 2L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 19L, 0L, 2L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 20L, 0L, 2L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 21L, 0L, 2L, 7L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 22L, 0L, 3L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 23L, 0L, 3L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 24L, 0L, 3L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 25L, 0L, 3L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 26L, 0L, 3L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 27L, 0L, 3L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 28L, 0L, 3L, 7L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 29L, 0L, 4L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 30L, 0L, 4L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 31L, 0L, 4L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 32L, 0L, 4L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 33L, 0L, 4L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 34L, 0L, 4L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 35L, 0L, 4L, 7L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 36L, 1L, 0L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 37L, 1L, 0L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 38L, 1L, 0L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 39L, 1L, 0L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 40L, 1L, 0L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 41L, 1L, 0L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 42L, 1L, 0L, 7L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 43L, 1L, 1L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 44L, 1L, 1L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 45L, 1L, 1L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 46L, 1L, 1L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 47L, 1L, 1L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 48L, 1L, 1L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 49L, 1L, 1L, 7L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 50L, 1L, 2L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 51L, 1L, 2L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 52L, 1L, 2L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 53L, 1L, 2L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 54L, 1L, 2L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 55L, 1L, 2L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 56L, 1L, 2L, 7L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 57L, 1L, 3L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 58L, 1L, 3L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 59L, 1L, 3L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 60L, 1L, 3L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 61L, 1L, 3L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 62L, 1L, 3L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 63L, 1L, 3L, 7L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 64L, 1L, 4L, 1L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 65L, 1L, 4L, 2L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 66L, 1L, 4L, 3L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 67L, 1L, 4L, 4L });

            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 68L, 1L, 4L, 5L });
            
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 69L, 1L, 4L, 6L });
                
            migrationBuilder.InsertData(table: "Periods",
                columns: new[] { "ID", "Week", "Day", "TimePeriod" },
                values: new object[] { 70L, 1L, 4L, 7L });
            
            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 31L });

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
                values: new object[] { 35L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 33L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 41L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 42L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 43L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 2L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 3L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 5L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 40L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 24L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 25L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 26L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 27L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 28L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 4L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 39L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 37L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 7L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 8L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 9L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 10L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 11L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 12L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 38L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 14L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 15L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 16L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 17L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 18L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 19L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 20L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 21L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 13L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 23L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 36L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 22L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 35L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 34L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 32L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 31L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 30L });

            migrationBuilder.InsertData(table: "RoomIDLessonID", columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 33L });

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

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 19L, 2L, "N2.15" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 12L, 2L, "N2.10" });

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
                values: new object[] { 18L, 2L, "N2.17" });

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
                values: new object[] { 30L, 2L, "N2.18" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 23L, 1L, "A1.4" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 22L, 2L, "N2.12" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 43L, 1L, "1.12" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 42L, 1L, "1.13" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 41L, 2L, "N2.23" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 40L, 1L, "A1.12" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 38L, 1L, "A1.16" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 37L, 2L, "N2.30" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 36L, 2L, "N2.8" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 35L, 0L, "Art 1" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 39L, 1L, "A1.15" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 33L, 2L, "N2.24" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 32L, 1L, "A1.13" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 31L, 2L, "N2.4" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 29L, 0L, "Gym 1" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 28L, 1L, "A1.14" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 27L, 0L, "N0.41" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 26L, 2L, "N2.14" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 25L, 2L, "N2.28" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 34L, 2L, "N2.25" });

            migrationBuilder.InsertData(table: "Rooms", columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 24L, 1L, "A1.6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 34L, "L1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 33L, "H11" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 32L, "H12" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 27L, "H5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 30L, "H8" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 29L, "H10" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 28L, "H6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 35L, "L3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 31L, "H9" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 36L, "L6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 46L, "G5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 38L, "P2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 39L, "P3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 40L, "P1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 41L, "G2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 42L, "G3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 43L, "G7" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 44L, "G4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 45L, "G8" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 26L, "H7" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 47L, "A3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 37L, "L5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 25L, "H1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 14L, "M5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 23L, "H2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 48L, "A4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 1L, "S8" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 2L, "S1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 3L, "S3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 4L, "S2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 5L, "S4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 6L, "S5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 7L, "S6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 8L, "S7" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 9L, "C1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 24L, "H4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 10L, "M6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 12L, "M1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 13L, "M2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 15L, "M3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 16L, "E3" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 17L, "E5" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 18L, "E1" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 19L, "E7" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 20L, "E2" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 21L, "E4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 22L, "E6" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 11L, "M4" });

            migrationBuilder.InsertData(table: "Teachers", columns: new[] { "ID", "Name" },
                values: new object[] { 49L, "A1" });
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