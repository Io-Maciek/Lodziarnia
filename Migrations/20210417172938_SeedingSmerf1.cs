using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class SeedingSmerf1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lody",
                columns: new[] { "SmakID", "SciezkaZdjecia", "SmakAlkohol", "SmakDostepny", "SmakNazwa", "SmakOpis" },
                values: new object[] { 1, null, false, true, "Truskawkowy", "Sorbet z soczystych polskich truskawek!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lody",
                keyColumn: "SmakID",
                keyValue: 1);
        }
    }
}
