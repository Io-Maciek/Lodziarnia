using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cennik",
                columns: new[] { "UseLessKey", "Duzy", "Galka", "Maly", "Sredni" },
                values: new object[] { 1, 5.0, 3.5, 3.5, 4.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "UseLessKey",
                keyValue: 1);
        }
    }
}
