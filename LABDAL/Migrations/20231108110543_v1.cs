using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LABDAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tomanycourses1",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tomanycourses1", x => x.course_id);
                });

            migrationBuilder.CreateTable(
                name: "tomanystudents1",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tomanystudents1", x => x.student_id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    student_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tomanycoursecourse_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.student_Id);
                    table.ForeignKey(
                        name: "FK_students_tomanycourses1_tomanycoursecourse_id",
                        column: x => x.tomanycoursecourse_id,
                        principalTable: "tomanycourses1",
                        principalColumn: "course_id");
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tomanystudentsstudent_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.course_id);
                    table.ForeignKey(
                        name: "FK_courses_tomanystudents1_tomanystudentsstudent_id",
                        column: x => x.tomanystudentsstudent_id,
                        principalTable: "tomanystudents1",
                        principalColumn: "student_id");
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    company_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    relatedto_studentstudent_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.company_id);
                    table.ForeignKey(
                        name: "FK_companies_students_relatedto_studentstudent_Id",
                        column: x => x.relatedto_studentstudent_Id,
                        principalTable: "students",
                        principalColumn: "student_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_relatedto_studentstudent_Id",
                table: "companies",
                column: "relatedto_studentstudent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_courses_tomanystudentsstudent_id",
                table: "courses",
                column: "tomanystudentsstudent_id");

            migrationBuilder.CreateIndex(
                name: "IX_students_tomanycoursecourse_id",
                table: "students",
                column: "tomanycoursecourse_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "tomanystudents1");

            migrationBuilder.DropTable(
                name: "tomanycourses1");
        }
    }
}
