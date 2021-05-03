using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class nwm3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Cennik_cennikRodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Lody_lodySmakID",
                table: "LodKategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LodKategoria",
                table: "LodKategoria");

            migrationBuilder.DropIndex(
                name: "IX_LodKategoria_cennikRodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropIndex(
                name: "IX_LodKategoria_lodySmakID",
                table: "LodKategoria");

            migrationBuilder.DropColumn(
                name: "KategoriaLodaCENNIK",
                table: "LodKategoria");

            migrationBuilder.DropColumn(
                name: "cennikRodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropColumn(
                name: "lodySmakID",
                table: "LodKategoria");

            migrationBuilder.AddColumn<string>(
                name: "RodzajLoda",
                table: "LodKategoria",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LodKategoria",
                table: "LodKategoria",
                columns: new[] { "SmakID", "RodzajLoda" });

            migrationBuilder.CreateIndex(
                name: "IX_LodKategoria_RodzajLoda",
                table: "LodKategoria",
                column: "RodzajLoda");

            migrationBuilder.AddForeignKey(
                name: "FK_LodKategoria_Cennik_RodzajLoda",
                table: "LodKategoria",
                column: "RodzajLoda",
                principalTable: "Cennik",
                principalColumn: "RodzajLoda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LodKategoria_Lody_SmakID",
                table: "LodKategoria",
                column: "SmakID",
                principalTable: "Lody",
                principalColumn: "SmakID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Cennik_RodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_LodKategoria_Lody_SmakID",
                table: "LodKategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LodKategoria",
                table: "LodKategoria");

            migrationBuilder.DropIndex(
                name: "IX_LodKategoria_RodzajLoda",
                table: "LodKategoria");

            migrationBuilder.DropColumn(
                name: "RodzajLoda",
                table: "LodKategoria");

            migrationBuilder.AddColumn<int>(
                name: "KategoriaLodaCENNIK",
                table: "LodKategoria",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_LodKategoria",
                table: "LodKategoria",
                columns: new[] { "SmakID", "KategoriaLodaCENNIK" });

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
    }
}
