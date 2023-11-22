using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTDAL.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "many",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_many", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "manytomanys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manytomanys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "manymanytomany",
                columns: table => new
                {
                    manysid = table.Column<int>(type: "int", nullable: false),
                    tomany2sid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manymanytomany", x => new { x.manysid, x.tomany2sid });
                    table.ForeignKey(
                        name: "FK_manymanytomany_many_manysid",
                        column: x => x.manysid,
                        principalTable: "many",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_manymanytomany_manytomanys_tomany2sid",
                        column: x => x.tomany2sid,
                        principalTable: "manytomanys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_manymanytomany_tomany2sid",
                table: "manymanytomany",
                column: "tomany2sid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manymanytomany");

            migrationBuilder.DropTable(
                name: "many");

            migrationBuilder.DropTable(
                name: "manytomanys");
        }
    }
}
