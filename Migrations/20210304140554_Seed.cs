using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GodzinyPracy",
                columns: new[] { "DzienID", "GodzinaEnd", "GodzinaStart", "MinutaEnd", "MinutaStart" },
                values: new object[,]
                {
                    { 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0 },
                    { 2, 0, 0, 0, 0 },
                    { 3, 0, 0, 0, 0 },
                    { 4, 0, 0, 0, 0 },
                    { 5, 0, 0, 0, 0 },
                    { 6, 0, 0, 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 6);
        }
    }
}
