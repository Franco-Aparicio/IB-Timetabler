using Microsoft.EntityFrameworkCore.Migrations;

namespace IB_Timetabler.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Block = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LessonIDBlockID",
                columns: table => new
                {
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    BlockID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonIDBlockID", x => new { x.BlockID, x.LessonID });
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<long>(type: "INTEGER", nullable: false),
                    Level = table.Column<string>(type: "TEXT", nullable: false),
                    ClassCode = table.Column<string>(type: "TEXT", nullable: false),
                    NumLessons = table.Column<long>(type: "INTEGER", nullable: false),
                    TeacherID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Week = table.Column<long>(type: "INTEGER", nullable: false),
                    Day = table.Column<long>(type: "INTEGER", nullable: false),
                    TimePeriod = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomIDLessonID",
                columns: table => new
                {
                    RoomID = table.Column<long>(type: "INTEGER", nullable: false),
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomIDLessonID", x => new { x.LessonID, x.RoomID });
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Floor = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SavedLessonIDPeriodID",
                columns: table => new
                {
                    SavedLessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    PeriodID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedLessonIDPeriodID", x => new { x.PeriodID, x.SavedLessonID });
                });

            migrationBuilder.CreateTable(
                name: "SavedLessons",
                columns: table => new
                {
                    SaveID = table.Column<long>(type: "INTEGER", nullable: false),
                    Lesson = table.Column<string>(type: "TEXT", nullable: false),
                    Teacher = table.Column<string>(type: "TEXT", nullable: false),
                    Room = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedLessons", x => new { x.Lesson, x.SaveID });
                });

            migrationBuilder.CreateTable(
                name: "Saves",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saves", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "ID", "Block" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "ID", "Block" },
                values: new object[] { 2L, 2L });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "ID", "Block" },
                values: new object[] { 3L, 3L });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "ID", "Block" },
                values: new object[] { 4L, 4L });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "ID", "Block" },
                values: new object[] { 5L, 5L });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "ID", "Block" },
                values: new object[] { 6L, 6L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 42L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 41L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 40L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 39L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 38L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 35L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 36L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 43L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 34L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 33L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 37L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 44L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 47L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 46L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 32L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 48L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 49L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 50L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 51L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 52L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 53L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 54L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 55L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 57L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 45L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 31L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 28L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 29L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 5L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 6L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 7L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 8L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 9L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 10L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 11L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 12L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 13L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 14L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 15L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 30L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 16L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 18L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 19L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 20L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 21L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 22L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 23L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 24L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 25L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 26L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 5L, 27L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 58L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 17L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 59L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 61L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 61L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 86L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 87L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 88L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 89L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 90L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 91L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 92L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 93L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 94L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 95L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 96L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 85L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 97L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 99L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 100L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 101L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 102L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 103L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 104L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 105L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 106L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 107L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 108L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 109L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 98L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 60L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 84L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 82L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 4L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 62L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 62L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 63L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 63L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 1L, 64L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 64L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 65L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 66L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 67L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 68L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 83L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 69L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 71L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 72L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 73L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 74L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 75L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 76L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 77L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 78L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 79L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 80L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 2L, 81L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 3L, 70L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 3L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 6L, 56L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 1L });

            migrationBuilder.InsertData(
                table: "LessonIDBlockID",
                columns: new[] { "BlockID", "LessonID" },
                values: new object[] { 4L, 2L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 30L, "13 AA SL/HL Mat", "SL", "13 AA SL/HL Mat", 6L, 30L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 31L, "13 AA HL Mat", "HL", "13 AA HL Mat", 4L, 31L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 32L, "12 SL Eng Lang & Lit 1", "SL", "12 SL Eng Lang & Lit 1", 6L, 32L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 33L, "12 SL Eng Lang & Lit 2", "SL", "12 SL Eng Lang & Lit 2", 6L, 33L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 34L, "12 HL Eng Lang & Lit 3", "HL", "12 HL Eng Lang & Lit 3", 10L, 34L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 35L, "12 HL Eng B 1", "HL", "12 HL Eng B 1", 10L, 35L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 36L, "12 HL Eng B 2", "HL", "12 HL Eng B 2", 10L, 36L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 37L, "12 HL Eng B 3", "HL", "12 HL Eng B 3", 10L, 37L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 38L, "13 SL Eng Lit 1", "SL", "13 SL Eng Lit 1", 6L, 38L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 39L, "13 HL Eng Lit 1", "HL", "13 HL Eng Lit 1", 10L, 39L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 40L, "13 HL Eng B 1", "HL", "13 HL Eng B 1", 10L, 40L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 41L, "13 HL Eng B 2", "HL", "13 HL Eng B 2", 10L, 41L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 42L, "23 SL Geog", "SL", "23 SL Geog", 6L, 42L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 43L, "23 HL Geog", "HL", "23 HL Geog", 4L, 43L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 44L, "22 SL Geog", "SL", "22 SL Geog", 6L, 44L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 45L, "22 HL Geog", "HL", "22 HL Geog", 4L, 45L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 46L, "23 SL His", "SL", "23 SL His", 6L, 46L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 47L, "23 HL His", "HL", "23 HL His", 4L, 47L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 48L, "22 SL His", "SL", "22 SL His", 6L, 48L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 49L, "22 HL His", "HL", "22 HL His", 4L, 49L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 50L, "23 SL Econ", "SL", "23 SL Econ", 6L, 50L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 51L, "23 HL Econ", "HL", "23 HL Econ", 4L, 51L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 52L, "22 SL Econ", "SL", "22 SL Econ", 6L, 52L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 53L, "22 HL Econ", "HL", "22 HL Econ", 4L, 53L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 28L, "13 AA SL Mat 1", "SL", "13 AA SL Mat 1", 6L, 28L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 27L, "13 AI HL Mat", "HL", "13 AI HL Mat", 4L, 27L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 26L, "13 AI SL/HL Mat", "HL", "13 AI SL/HL Mat", 6L, 26L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 25L, "13 AI SL Mat", "SL", "13 AI SL Mat", 6L, 25L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 1L, "12 SL Bio", "SL", "12 SL Bio", 6L, 1L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 2L, "12 HL Bio Z1", "HL", "12 HL Bio Z1", 10L, 2L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 3L, "12 HL Bio Z2", "HL", "12 HL Bio Z2", 10L, 3L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 4L, "12 SL Che", "SL", "12 SL Che", 6L, 4L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 5L, "12 HL Che", "HL", "12 HL Che", 4L, 5L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 6L, "12 SL Phy", "SL", "12 SL Phy", 6L, 6L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 7L, "12 HL Phy", "HL", "12 HL Phy", 4L, 7L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 8L, "13 SL Bio", "SL", "13 SL Bio", 6L, 8L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 9L, "13 HL Bio Z1", "HL", "13 HL Bio Z1", 10L, 9L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 10L, "13 HL Bio Z2", "HL", "13 HL Bio Z2", 10L, 10L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 11L, "13 SL Che", "SL", "13 SL Che", 6L, 11L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 54L, "23 SL A BUSMAN", "SL", "23 SL A BUSMAN", 6L, 54L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 12L, "13 HL Che", "HL", "13 HL Che", 4L, 12L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 14L, "13 HL Phy", "HL", "13 HL Phy", 4L, 14L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 15L, "12 SL Comp", "SL", "12 SL Comp", 6L, 15L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 16L, "12 HL Comp", "HL", "12 HL Comp", 4L, 16L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 17L, "13 SL Comp", "SL", "13 SL Comp", 6L, 17L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 18L, "13 HL Comp", "HL", "13 HL Comp", 4L, 18L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 19L, "12 AI SL Mat", "SL", "12 AI SL Mat", 6L, 19L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 20L, "12 AI SL/HL Mat", "HL", "12 AI SL/HL Mat", 6L, 20L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 21L, "12 AI HL Mat", "HL", "12 AI HL Mat", 4L, 21L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 22L, "12 AA SL Mat", "SL", "12 AA SL Mat", 6L, 22L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 23L, "12 AA SL/HL Mat", "HL", "12 AA SL/HL Mat", 6L, 23L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 24L, "12 AA HL Mat", "HL", "12 AA HL Mat", 4L, 24L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 13L, "13 SL Phy", "SL", "13 SL Phy", 6L, 13L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 55L, "23 HL A BUSMAN", "HL", "23 HL A BUSMAN", 4L, 55L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 29L, "13 AA SL Mat 2", "SL", "13 AA SL Mat 2", 6L, 29L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 57L, "23 HL B BUSMAN", "HL", "23 HL B BUSMAN", 4L, 57L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 85L, "12 HL SEHS", "HL", "12 HL SEHS", 4L, 85L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 86L, "13 SL SEHS", "SL", "13 SL SEHS", 6L, 86L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 87L, "13 HL SEHS", "HL", "13 HL SEHS", 4L, 87L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 88L, "GER LL 12Z1 SL", "SL", "GER LL 12Z1 SL", 6L, 88L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 89L, "GER LL 12Z2 SL", "SL", "GER LL 12Z2 SL", 6L, 89L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 90L, "GER LL 12 HL", "HL", "GER LL 12 HL", 4L, 90L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 91L, "GER LL 13Z1 SL", "SL", "GER LL 13Z1 SL", 6L, 91L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 92L, "GER LL 13Z2 SL", "SL", "GER LL 13Z2 SL", 6L, 92L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 93L, "GER LL 13 HL", "HL", "GER LL 13 HL", 4L, 93L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 94L, "GER B 12 Z1 SL", "SL", "GER B 12 Z1 SL", 6L, 94L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 95L, "GER B 12 Z2 SL", "SL", "GER B 12 Z2 SL", 6L, 95L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 96L, "GER B 12 HL", "HL", "GER B 12 HL", 4L, 96L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 97L, "GER AI 12 Z1", "SL", "GER AI 12 Z1", 6L, 97L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 98L, "GER B 13 Z1 SL", "SL", "GER B 13 Z1 SL", 6L, 98L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 99L, "GER B 13 Z2 SL", "SL", "GER B 13 Z2 SL", 6L, 99L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 100L, "GER B 13 HL", "HL", "GER B 13 HL", 4L, 100L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 101L, "GER AI 13 Z1", "SL", "GER AI 13 Z1", 6L, 101L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 102L, "12 SL Visual Arts", "SL", "12 SL Visual Arts", 6L, 102L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 103L, "12 HL Visual Arts", "HL", "12 HL Visual Arts", 4L, 103L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 104L, "13 SL Visual Arts", "SL", "13 SL Visual Arts", 6L, 104L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 105L, "13 HL Visual Arts", "HL", "13 HL Visual Arts", 4L, 105L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 106L, "12 SL Theatre", "SL", "12 SL Theatre", 6L, 106L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 107L, "12 HL Theatre", "HL", "12 HL Theatre", 4L, 107L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 108L, "13 SL Theatre", "SL", "13 SL Theatre", 6L, 108L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 56L, "23 SL B BUSMAN", "SL", "23 SL B BUSMAN", 6L, 56L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 84L, "12 SL SEHS", "SL", "12 SL SEHS", 6L, 84L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 83L, "SPA 13 LD", "SL", "SPA 13 LD", 2L, 83L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 109L, "13 HL Theatre", "HL", "13 HL Theatre", 4L, 109L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 81L, "SPA B 13 SL", "SL", "SPA B 13 SL", 6L, 81L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 82L, "SPA B 13 HL", "HL", "SPA B 13 HL", 4L, 82L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 58L, "22 SL S3B BUSMAN", "SL", "22 SL S3B BUSMAN", 6L, 58L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 59L, "22 SL S3C BUSMAN", "SL", "22 SL S3C BUSMAN", 6L, 59L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 60L, "22 HL S3B BUSMAN", "HL", "22 HL S3B BUSMAN", 4L, 60L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 61L, "BTEC Y12", "HL", "BTEC Y12", 14L, 61L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 62L, "BTEC Y13", "HL", "BTEC Y13", 14L, 62L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 63L, "PPS Y12", "HL", "PPS Y12", 4L, 63L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 64L, "PPS Y13", "HL", "PPS Y13", 4L, 64L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 66L, "23 HL GloPo", "HL", "23 HL GloPo", 4L, 66L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 67L, "22 SL 223S GloPo", "SL", "22 SL 223S GloPo", 6L, 67L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 68L, "22 HL 223S GloPo", "HL", "22 HL 223S GloPo", 4L, 68L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 69L, "23 SL Psy", "SL", "23 SL Psy", 6L, 69L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 65L, "23 SL GloPo", "SL", "23 SL GloPo", 6L, 65L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 71L, "22 SL 22S3 Psy", "SL", "22 SL 22S3 Psy", 6L, 71L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 70L, "23 HL Psy", "HL", "23 HL Psy", 4L, 70L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 79L, "SPA 12 LD", "HL", "SPA 12 LD", 2L, 79L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 78L, "SPA B 12 HL", "HL", "SPA B 12 HL", 4L, 78L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 77L, "SPA B 12 SL", "SL", "SPA B 12 SL", 6L, 77L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 76L, "FRE AI SL", "SL", "FRE AI SL", 6L, 76L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 80L, "SPA 12 AI SL", "SL", "SPA 12 AI SL", 6L, 80L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 74L, "FRE B 12 HL", "HL", "FRE B 12 HL", 4L, 74L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 73L, "FRE B 12 SL", "SL", "FRE B 12 SL", 6L, 73L, 12L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 72L, "22 HL 22S3 Psy", "HL", "22 HL 22S3 Psy", 4L, 72L, 13L });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "ID", "ClassCode", "Level", "Name", "NumLessons", "TeacherID", "Year" },
                values: new object[] { 75L, "FRE B 13 SL", "SL", "FRE B 13 SL", 6L, 75L, 13L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 30L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 38L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 37L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 36L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 35L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 34L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 33L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 32L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 31L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 39L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 29L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 17L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 27L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 26L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 25L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 24L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 23L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 22L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 21L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 20L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 19L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 18L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 40L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 16L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 28L, 5L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 41L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 54L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 43L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 15L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 64L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 63L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 62L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 61L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 60L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 59L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 58L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 57L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 56L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 55L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 53L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 52L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 51L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 50L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 49L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 48L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 47L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 46L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 45L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 44L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 42L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 14L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 109L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 12L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 85L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 86L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 87L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 88L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 89L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 90L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 91L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 92L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 93L, 1L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 94L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 95L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 96L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 97L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 98L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 99L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 100L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 101L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 102L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 103L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 104L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 105L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 106L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 107L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 108L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 65L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 84L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 13L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 83L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 81L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 11L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 10L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 9L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 8L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 7L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 6L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 5L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 4L, 6L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 3L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 2L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 1L, 4L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 67L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 68L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 69L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 70L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 71L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 72L, 3L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 73L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 74L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 75L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 76L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 77L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 78L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 79L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 80L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 82L, 2L });

            migrationBuilder.InsertData(
                table: "RoomIDLessonID",
                columns: new[] { "LessonID", "RoomID" },
                values: new object[] { 66L, 3L });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 19L, 2L, "N2.15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 42L, 1L, "1.13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 18L, 2L, "N2.17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 17L, 2L, "N2.20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 16L, 2L, "N2.29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 15L, 0L, "N0.40" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 14L, 2L, "N2.11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 13L, 1L, "A1.2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 12L, 2L, "N2.10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 11L, 1L, "A1.3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 20L, 2L, "N2.2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 10L, 0L, "A0.2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 7L, 2L, "N2.6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 6L, 0L, "Gym 3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 5L, 0L, "Art 2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 4L, 2L, "N2.13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 3L, 0L, "A0.11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 2L, 1L, "Hall" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 1L, 0L, "Gym 2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 43L, 1L, "1.12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 8L, 2L, "N2.27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 21L, 2L, "N2.22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 9L, 2L, "N2.16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 23L, 1L, "A1.4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 41L, 2L, "N2.23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 22L, 2L, "N2.12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 40L, 1L, "A1.12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 39L, 1L, "A1.15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 38L, 1L, "A1.16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 37L, 2L, "N2.30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 35L, 0L, "Art 1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 34L, 2L, "N2.25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 33L, 2L, "N2.24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 36L, 2L, "N2.8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 31L, 2L, "N2.4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 30L, 2L, "N2.18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 29L, 0L, "Gym 1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 28L, 1L, "A1.14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 27L, 0L, "N0.41" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 26L, 2L, "N2.14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 25L, 2L, "N2.28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 32L, 1L, "A1.13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Floor", "Number" },
                values: new object[] { 24L, 1L, "A1.6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 78L, "L6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 71L, "H11" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 72L, "H11" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 73L, "L1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 79L, "L3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 77L, "L6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 75L, "L3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 76L, "L1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 70L, "H12" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 74L, "L3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 69L, "H12" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 60L, "H8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 67L, "H5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 66L, "H1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 65L, "H1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 64L, "H8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 63L, "H9" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 62L, "H8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 61L, "H9" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 59L, "H9" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 58L, "H8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 80L, "L5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 57L, "H9" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 68L, "H5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 81L, "L6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 101L, "G5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 83L, "L3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 107L, "A1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 106L, "A1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 105L, "A4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 104L, "A4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 103L, "A3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 102L, "A3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 56L, "H10" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 100L, "G7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 99L, "G4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 98L, "G7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 97L, "G8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 82L, "L6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 96L, "G7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 94L, "G7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 93L, "G2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 92L, "G3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 91L, "G2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 90L, "G2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 89L, "G3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 88L, "G2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 87L, "P3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 86L, "P1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 85L, "P3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 84L, "P2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 95L, "G4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 55L, "H8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 34L, "E1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 53L, "H10" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 23L, "M2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 22L, "M1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 21L, "M4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 20L, "M4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 19L, "M6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 18L, "C1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 17L, "C1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 16L, "C1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 15L, "C1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 14L, "S4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 13L, "S4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 24L, "M2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 12L, "S7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 10L, "S8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 9L, "S6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 8L, "S5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 7L, "S4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 6L, "S4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 5L, "S2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 4L, "S2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3L, "S3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2L, "S1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1L, "S8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 108L, "A1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 11L, "S7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 54L, "H8" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 25L, "M5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 27L, "M4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 52L, "H10" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 51L, "H10" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 50L, "H10" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 49L, "H6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 48L, "H6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 47L, "H5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 46L, "H7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 45L, "H1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 44L, "H4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 43L, "H2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 42L, "H2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 26L, "M4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 41L, "E5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 39L, "E6" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 38L, "E1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 37L, "E4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 36L, "E2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 35L, "E7" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 33L, "E5" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 32L, "E3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 31L, "M1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 30L, "M1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 29L, "M3" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 28L, "M2" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 40L, "E4" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Name" },
                values: new object[] { 109L, "A1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "LessonIDBlockID");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "RoomIDLessonID");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "SavedLessonIDPeriodID");

            migrationBuilder.DropTable(
                name: "SavedLessons");

            migrationBuilder.DropTable(
                name: "Saves");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
