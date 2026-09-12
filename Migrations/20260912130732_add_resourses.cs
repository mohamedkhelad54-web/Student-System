using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class add_resourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "resourses",
                columns: table => new
                {
                    resourseid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ulr = table.Column<string>(type: "varchar(50)", nullable: false),
                    resourceType = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resourses", x => x.resourseid);
                    table.ForeignKey(
                        name: "FK_resourses_students_studentid",
                        column: x => x.studentid,
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resourses_studentid",
                table: "resourses",
                column: "studentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resourses");
        }
    }
}
