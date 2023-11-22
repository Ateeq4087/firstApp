using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTDAL.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "oness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "to_Ones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    relatedto_oneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_to_Ones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_to_Ones_oness_relatedto_oneId",
                        column: x => x.relatedto_oneId,
                        principalTable: "oness",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_to_Ones_relatedto_oneId",
                table: "to_Ones",
                column: "relatedto_oneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "to_Ones");

            migrationBuilder.DropTable(
                name: "oness");
        }
    }
}
