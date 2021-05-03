using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cennik",
                columns: table => new
                {
                    UseLessKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Galka = table.Column<double>(type: "float", nullable: false),
                    Maly = table.Column<double>(type: "float", nullable: false),
                    Sredni = table.Column<double>(type: "float", nullable: false),
                    Duzy = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cennik", x => x.UseLessKey);
                });

            migrationBuilder.CreateTable(
                name: "GodzinyPracy",
                columns: table => new
                {
                    DzienID = table.Column<int>(type: "int", nullable: false),
                    GodzinaStart = table.Column<int>(type: "int", nullable: false),
                    MinutaStart = table.Column<int>(type: "int", nullable: false),
                    GodzinaEnd = table.Column<int>(type: "int", nullable: false),
                    MinutaEnd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodzinyPracy", x => x.DzienID);
                });

            migrationBuilder.CreateTable(
                name: "Lody",
                columns: table => new
                {
                    SmakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmakNazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmakOpis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmakDostepny = table.Column<bool>(type: "bit", nullable: false),
                    SmakAlkohol = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lody", x => x.SmakID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cennik");

            migrationBuilder.DropTable(
                name: "GodzinyPracy");

            migrationBuilder.DropTable(
                name: "Lody");
        }
    }
}
