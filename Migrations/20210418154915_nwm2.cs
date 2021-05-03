using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class nwm2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cennik",
                columns: new[] { "RodzajLoda", "Cena", "KategoriaLoda" },
                values: new object[,]
                {
                    { "gałka", 3.0, 1 },
                    { "mały", 3.0, 0 },
                    { "średni", 3.5, 0 },
                    { "duży", 4.5, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "RodzajLoda",
                keyValue: "duży");

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "RodzajLoda",
                keyValue: "gałka");

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "RodzajLoda",
                keyValue: "mały");

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "RodzajLoda",
                keyValue: "średni");
        }
    }
}
