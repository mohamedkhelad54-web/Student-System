using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "homeworks",
                columns: table => new
                {
                    homeworkid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contentypes = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homeworks", x => x.homeworkid);
                    table.ForeignKey(
                        name: "FK_homeworks_courses_courseid",
                        column: x => x.courseid,
                        principalTable: "courses",
                        principalColumn: "courseid");
                    table.ForeignKey(
                        name: "FK_homeworks_students_studentid",
                        column: x => x.studentid,
                        principalTable: "students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_homeworks_courseid",
                table: "homeworks",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "IX_homeworks_studentid",
                table: "homeworks",
                column: "studentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homeworks");
        }
    }
}
