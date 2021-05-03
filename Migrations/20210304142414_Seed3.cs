using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SmakNazwa",
                table: "Lody",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Lody",
                columns: new[] { "SmakID", "SmakAlkohol", "SmakDostepny", "SmakNazwa", "SmakOpis" },
                values: new object[] { 1, false, true, "Truskawkowy", "Sorbet z soczystych polskich truskawek!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lody",
                keyColumn: "SmakID",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "SmakNazwa",
                table: "Lody",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
