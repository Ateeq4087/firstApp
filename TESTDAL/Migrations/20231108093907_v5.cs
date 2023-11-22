using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTDAL.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tomany1id",
                table: "oness",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tomany1s",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tomany1s", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_oness_tomany1id",
                table: "oness",
                column: "tomany1id");

            migrationBuilder.AddForeignKey(
                name: "FK_oness_tomany1s_tomany1id",
                table: "oness",
                column: "tomany1id",
                principalTable: "tomany1s",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_oness_tomany1s_tomany1id",
                table: "oness");

            migrationBuilder.DropTable(
                name: "tomany1s");

            migrationBuilder.DropIndex(
                name: "IX_oness_tomany1id",
                table: "oness");

            migrationBuilder.DropColumn(
                name: "tomany1id",
                table: "oness");
        }
    }
}
