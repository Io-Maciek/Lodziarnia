using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class SeedLodSmerf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lody",
                keyColumn: "SmakID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Lody",
                columns: new[] { "SmakID", "SciezkaZdjecia", "SmakAlkohol", "SmakDostepny", "SmakNazwa", "SmakOpis" },
                values: new object[] { 2, null, false, true, "Smerfowy", "Gargamel by się cieszył!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lody",
                keyColumn: "SmakID",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Lody",
                columns: new[] { "SmakID", "SciezkaZdjecia", "SmakAlkohol", "SmakDostepny", "SmakNazwa", "SmakOpis" },
                values: new object[] { 1, null, false, true, "Truskawkowy", "Sorbet z soczystych polskich truskawek!" });
        }
    }
}
