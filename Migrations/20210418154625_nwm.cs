using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class nwm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Cennik_KategoriaLodaCENNIK",
                table: "LodKategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Lody_SmakID",
                table: "LodKategoria");

            migrationBuilder.DropIndex(
                name: "IX_LodKategoria_KategoriaLodaCENNIK",
                table: "LodKategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik");

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



            migrationBuilder.AddColumn<string>(
                name: "cennikRodzajLoda",
                table: "LodKategoria",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "lodySmakID",
                table: "LodKategoria",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RodzajLoda",
                table: "Cennik",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik",
                column: "RodzajLoda");

            migrationBuilder.CreateIndex(
                name: "IX_LodKategoria_cennikRodzajLoda",
                table: "LodKategoria",
                column: "cennikRodzajLoda");

            migrationBuilder.CreateIndex(
                name: "IX_LodKategoria_lodySmakID",
                table: "LodKategoria",
                column: "lodySmakID");

            migrationBuilder.AddForeignKey(
                name: "FK_LodKategoria_Cennik_cennikRodzajLoda",
                table: "LodKategoria",
                column: "cennikRodzajLoda",
                principalTable: "Cennik",
                principalColumn: "RodzajLoda",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LodKategoria_Lody_lodySmakID",
                table: "LodKategoria",
                column: "lodySmakID",
                principalTable: "Lody",
                principalColumn: "SmakID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Cennik_cennikRodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Lody_lodySmakID",
                table: "LodKategoria");

            migrationBuilder.DropIndex(
                name: "IX_LodKategoria_cennikRodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropIndex(
                name: "IX_LodKategoria_lodySmakID",
                table: "LodKategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik");

            migrationBuilder.DropColumn(
                name: "cennikRodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropColumn(
                name: "lodySmakID",
                table: "LodKategoria");

            migrationBuilder.AlterColumn<string>(
                name: "RodzajLoda",
                table: "Cennik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");


            migrationBuilder.AddPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik",
                column: "KategoriaLoda");

            migrationBuilder.InsertData(
                table: "GodzinyPracy",
                columns: new[] { "DzienID", "GodzinaEnd", "GodzinaStart", "MinutaEnd", "MinutaStart" },
                values: new object[,]
                {
                    { 0, 16, 10, 30, 0 },
                    { 1, 13, 9, 50, 45 },
                    { 2, 23, 31, 30, 0 },
                    { 3, 23, 12, 0, 30 },
                    { 4, 20, 18, 0, 12 },
                    { 5, 23, 8, 0, 2 },
                    { 6, 21, 15, 0, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LodKategoria_KategoriaLodaCENNIK",
                table: "LodKategoria",
                column: "KategoriaLodaCENNIK");

            migrationBuilder.AddForeignKey(
                name: "FK_LodKategoria_Cennik_KategoriaLodaCENNIK",
                table: "LodKategoria",
                column: "KategoriaLodaCENNIK",
                principalTable: "Cennik",
                principalColumn: "KategoriaLoda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LodKategoria_Lody_SmakID",
                table: "LodKategoria",
                column: "SmakID",
                principalTable: "Lody",
                principalColumn: "SmakID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
