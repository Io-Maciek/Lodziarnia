using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 2,
                column: "GodzinaStart",
                value: 31);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GodzinyPracy",
                keyColumn: "DzienID",
                keyValue: 2,
                column: "GodzinaStart",
                value: 17);
        }
    }
}
