using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.DAL.Migrations
{
    public partial class AddedDescriere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descriere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pret = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Nota = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    Recomandare = table.Column<int>(type: "int", nullable: true),
                    An_aparitie = table.Column<int>(type: "int", nullable: false),
                    Volum = table.Column<int>(type: "int", nullable: false),
                    Gen_principal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriere", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descriere");
        }
    }
}
