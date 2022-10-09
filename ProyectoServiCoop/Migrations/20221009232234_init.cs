using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoServiCoop.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "controle",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecharealizada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    km = table.Column<int>(type: "int", nullable: false),
                    opinion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    realizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_controle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "servi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecharealizada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    km = table.Column<int>(type: "int", nullable: false),
                    proxservi = table.Column<int>(type: "int", nullable: false),
                    realizado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servi", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "controle");

            migrationBuilder.DropTable(
                name: "servi");
        }
    }
}
