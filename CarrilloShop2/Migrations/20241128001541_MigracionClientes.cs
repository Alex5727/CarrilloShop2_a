using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarrilloShop2.Migrations
{
    public partial class MigracionClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CliCorreo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CliNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliApellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliCelular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliFechReg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CliAntiguedad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CliCorreo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
