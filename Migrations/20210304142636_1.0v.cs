using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class _10v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SciezkaZdjecia",
                table: "Lody",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SciezkaZdjecia",
                table: "Lody");
        }
    }
}
