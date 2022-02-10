using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.DAL.Migrations
{
    public partial class AddedCarteMagazinAndMagazinChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Disponibilitate",
                table: "CarteMagazine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stoc",
                table: "CarteMagazine",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibilitate",
                table: "CarteMagazine");

            migrationBuilder.DropColumn(
                name: "Stoc",
                table: "CarteMagazine");
        }
    }
}
