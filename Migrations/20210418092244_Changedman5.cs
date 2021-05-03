﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Lodziarnia.Migrations
{
    public partial class Changedman5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cennik",
                columns: table => new
                {
                    UselessKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriaLoda = table.Column<int>(type: "int", nullable: false),
                    RodzajLoda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cennik", x => x.UselessKey);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cennik");
        }
    }
}
