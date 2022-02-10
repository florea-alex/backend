using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.DAL.Migrations
{
    public partial class AddedCarteMagazinAndMagazin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cod_postal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarteMagazine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarteId = table.Column<int>(type: "int", nullable: false),
                    MagazinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteMagazine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteMagazine_Carti_MagazinId",
                        column: x => x.MagazinId,
                        principalTable: "Carti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarteMagazine_Magazine_CarteId",
                        column: x => x.CarteId,
                        principalTable: "Magazine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarteMagazine_CarteId",
                table: "CarteMagazine",
                column: "CarteId");

            migrationBuilder.CreateIndex(
                name: "IX_CarteMagazine_MagazinId",
                table: "CarteMagazine",
                column: "MagazinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarteMagazine");

            migrationBuilder.DropTable(
                name: "Magazine");
        }
    }
}
