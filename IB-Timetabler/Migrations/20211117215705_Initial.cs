using Microsoft.EntityFrameworkCore.Migrations;

namespace IB_Timetabler.Migrations {
    
    public partial class Initial : Migration {
        
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Block = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Blocks", x => x.ID); });

            migrationBuilder.CreateTable(
                name: "LessonIDBlockID",
                columns: table => new {
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    BlockID = table.Column<long>(type: "INTEGER", nullable: false) },
                constraints: table => { });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<long>(type: "INTEGER", nullable: false),
                    Level = table.Column<string>(type: "TEXT", nullable: false),
                    ClassCode = table.Column<string>(type: "TEXT", nullable: false),
                    NumLessons = table.Column<long>(type: "INTEGER", nullable: false),
                    TeacherID = table.Column<long>(type: "INTEGER", nullable: false) },
                constraints: table => {
                    table.PrimaryKey("PK_Lessons", x => x.ID); });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Week = table.Column<long>(type: "INTEGER", nullable: false),
                    Day = table.Column<long>(type: "INTEGER", nullable: false),
                    TimePeriod = table.Column<long>(type: "INTEGER", nullable: false) },
                constraints: table => {
                    table.PrimaryKey("PK_Periods", x => x.ID); });

            migrationBuilder.CreateTable(
                name: "RoomIDLessonID",
                columns: table => new {
                    RoomID = table.Column<long>(type: "INTEGER", nullable: false),
                    LessonID = table.Column<long>(type: "INTEGER", nullable: false) },
                constraints: table => { });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Floor = table.Column<long>(type: "INTEGER", nullable: false) },
                constraints: table => {
                    table.PrimaryKey("PK_Rooms", x => x.ID); });

            migrationBuilder.CreateTable(
                name: "SavedLessonIDPeriodID",
                columns: table => new {
                    SavedLessonID = table.Column<long>(type: "INTEGER", nullable: false),
                    PeriodID = table.Column<long>(type: "INTEGER", nullable: false) },
                constraints: table => { });

            migrationBuilder.CreateTable(
                name: "SavedLessons",
                columns: table => new {
                    SaveID = table.Column<long>(type: "INTEGER", nullable: false),
                    Lesson = table.Column<string>(type: "TEXT", nullable: false),
                    Teacher = table.Column<string>(type: "TEXT", nullable: false),
                    Room = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table => { });

            migrationBuilder.CreateTable(
                name: "Saves",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false) },
                constraints: table => {
                    table.PrimaryKey("PK_Saves", x => x.ID); });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false) },
                constraints: table => {
                    table.PrimaryKey("PK_Teachers", x => x.ID); });
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
