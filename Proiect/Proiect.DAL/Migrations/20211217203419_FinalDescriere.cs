using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.DAL.Migrations
{
    public partial class FinalDescriere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biografie_Autori_AutorId",
                table: "Biografie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biografie",
                table: "Biografie");

            migrationBuilder.RenameTable(
                name: "Biografie",
                newName: "Biografii");

            migrationBuilder.RenameIndex(
                name: "IX_Biografie_AutorId",
                table: "Biografii",
                newName: "IX_Biografii_AutorId");

            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "Angajati",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_real",
                table: "Biografii",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nationalitate",
                table: "Biografii",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Loc_nastere",
                table: "Biografii",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biografii",
                table: "Biografii",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CNP = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facturi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_factura = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AngajatId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturi_Angajati_AngajatId",
                        column: x => x.AngajatId,
                        principalTable: "Angajati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturi_Clienti_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturi_AngajatId",
                table: "Facturi",
                column: "AngajatId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturi_ClientId",
                table: "Facturi",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biografii_Autori_AutorId",
                table: "Biografii",
                column: "AutorId",
                principalTable: "Autori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biografii_Autori_AutorId",
                table: "Biografii");

            migrationBuilder.DropTable(
                name: "Facturi");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biografii",
                table: "Biografii");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "Angajati");

            migrationBuilder.RenameTable(
                name: "Biografii",
                newName: "Biografie");

            migrationBuilder.RenameIndex(
                name: "IX_Biografii_AutorId",
                table: "Biografie",
                newName: "IX_Biografie_AutorId");

            migrationBuilder.AlterColumn<string>(
                name: "Nume_real",
                table: "Biografie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Nationalitate",
                table: "Biografie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Loc_nastere",
                table: "Biografie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biografie",
                table: "Biografie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Biografie_Autori_AutorId",
                table: "Biografie",
                column: "AutorId",
                principalTable: "Autori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
