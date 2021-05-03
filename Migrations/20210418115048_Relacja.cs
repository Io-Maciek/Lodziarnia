using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Relacja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik");

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "UselessKey",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "UselessKey",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "UselessKey",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cennik",
                keyColumn: "UselessKey",
                keyValue: 4);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik",
                column: "KategoriaLoda");

            migrationBuilder.CreateTable(
                name: "LodKategoria",
                columns: table => new
                {
                    SmakID = table.Column<int>(type: "int", nullable: false),
                    KategoriaLodaCENNIK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LodKategoria", x => new { x.SmakID, x.KategoriaLodaCENNIK });
                    table.ForeignKey(
                        name: "FK_LodKategoria_Cennik_KategoriaLodaCENNIK",
                        column: x => x.KategoriaLodaCENNIK,
                        principalTable: "Cennik",
                        principalColumn: "KategoriaLoda",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LodKategoria_Lody_SmakID",
                        column: x => x.SmakID,
                        principalTable: "Lody",
                        principalColumn: "SmakID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LodKategoria_KategoriaLodaCENNIK",
                table: "LodKategoria",
                column: "KategoriaLodaCENNIK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LodKategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik");



            migrationBuilder.AddPrimaryKey(
                name: "PK_Cennik",
                table: "Cennik",
                column: "UselessKey");

            migrationBuilder.InsertData(
                table: "Cennik",
                columns: new[] { "UselessKey", "Cena", "KategoriaLoda", "RodzajLoda" },
                values: new object[,]
                {
                    { 1, 3.0, 1, "gałka" },
                    { 2, 3.0, 0, "mały" },
                    { 3, 3.5, 0, "średni" },
                    { 4, 4.5, 0, "mały" }
                });
        }
    }
}
