using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.DAL.Migrations
{
    public partial class AddedEditura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EdituraId",
                table: "Carti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Edituri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cod_postal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CarteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edituri", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carti_EdituraId",
                table: "Carti",
                column: "EdituraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carti_Edituri_EdituraId",
                table: "Carti",
                column: "EdituraId",
                principalTable: "Edituri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carti_Edituri_EdituraId",
                table: "Carti");

            migrationBuilder.DropTable(
                name: "Edituri");

            migrationBuilder.DropIndex(
                name: "IX_Carti_EdituraId",
                table: "Carti");

            migrationBuilder.DropColumn(
                name: "EdituraId",
                table: "Carti");
        }
    }
}
