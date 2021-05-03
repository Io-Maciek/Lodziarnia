using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Changedman2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik");

            migrationBuilder.DropColumn(
                name: "Duzy",
                table: "Cennik");

            migrationBuilder.DropColumn(
                name: "Galka",
                table: "Cennik");

            migrationBuilder.DropColumn(
                name: "Maly",
                table: "Cennik");

            migrationBuilder.RenameTable(
                name: "Cennik",
                newName: "Ceny");

            migrationBuilder.RenameColumn(
                name: "UseLessKey",
                table: "Ceny",
                newName: "UselessKey");

            migrationBuilder.RenameColumn(
                name: "Sredni",
                table: "Ceny",
                newName: "Cena");

            migrationBuilder.AddColumn<int>(
                name: "kategoriaLoda",
                table: "Lody",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategoriaLoda",
                table: "Ceny",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RodzajLoda",
                table: "Ceny",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ceny",
                table: "Ceny",
                column: "UselessKey");

            migrationBuilder.UpdateData(
                table: "Ceny",
                keyColumn: "UselessKey",
                keyValue: 1,
                columns: new[] { "Cena", "KategoriaLoda", "RodzajLoda" },
                values: new object[] { 3.0, 1, "gałka" });

            migrationBuilder.InsertData(
                table: "Ceny",
                columns: new[] { "UselessKey", "Cena", "KategoriaLoda", "RodzajLoda" },
                values: new object[,]
                {
                    { 2, 3.0, 0, "mały" },
                    { 3, 3.5, 0, "średni" },
                    { 4, 4.5, 0, "mały" }
                });

            migrationBuilder.UpdateData(
                table: "Lody",
                keyColumn: "SmakID",
                keyValue: 1,
                column: "kategoriaLoda",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lody",
                keyColumn: "SmakID",
                keyValue: 2,
                column: "kategoriaLoda",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ceny",
                table: "Ceny");

            migrationBuilder.DeleteData(
                table: "Ceny",
                keyColumn: "UselessKey",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ceny",
                keyColumn: "UselessKey",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ceny",
                keyColumn: "UselessKey",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "kategoriaLoda",
                table: "Lody");

            migrationBuilder.DropColumn(
                name: "KategoriaLoda",
                table: "Ceny");

            migrationBuilder.DropColumn(
                name: "RodzajLoda",
                table: "Ceny");

            migrationBuilder.RenameTable(
                name: "Ceny",
                newName: "Cennik");

            migrationBuilder.RenameColumn(
                name: "UselessKey",
                table: "Cennik",
                newName: "UseLessKey");

            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "Cennik",
                newName: "Sredni");

            migrationBuilder.AddColumn<double>(
                name: "Duzy",
                table: "Cennik",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Galka",
                table: "Cennik",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Maly",
                table: "Cennik",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik",
                column: "UseLessKey");

            migrationBuilder.UpdateData(
                table: "Cennik",
                keyColumn: "UseLessKey",
                keyValue: 1,
                columns: new[] { "Duzy", "Galka", "Maly", "Sredni" },
                values: new object[] { 5.0, 3.5, 3.5, 4.5 });
        }
    }
}
