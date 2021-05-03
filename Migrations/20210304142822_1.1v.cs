using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class _11v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 0,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaEnd" },
                values: new object[] { 16, 10, 30 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 1,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaEnd", "MinutaStart" },
                values: new object[] { 13, 9, 50, 45 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 2,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaEnd" },
                values: new object[] { 23, 17, 30 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 3,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaStart" },
                values: new object[] { 23, 12, 30 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 4,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaStart" },
                values: new object[] { 20, 18, 12 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 5,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaStart" },
                values: new object[] { 23, 8, 2 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 6,
                columns: new[] { "GodzinaEnd", "GodzinaStart" },
                values: new object[] { 21, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 0,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaEnd" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 1,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaEnd", "MinutaStart" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 2,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaEnd" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 3,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaStart" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 4,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaStart" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 5,
                columns: new[] { "GodzinaEnd", "GodzinaStart", "MinutaStart" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 6,
                columns: new[] { "GodzinaEnd", "GodzinaStart" },
                values: new object[] { 0, 0 });
        }
    }
}
