using Microsoft.EntityFrameworkCore.Migrations;

namespace CarrilloShop2.Migrations
{
    public partial class Reisetodoooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Clientes_CliCorreo",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_CliCorreo",
                table: "Carritos");

            migrationBuilder.DropColumn(
                name: "CliAntiguedad",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "CliTelefono",
                table: "Clientes",
                newName: "CliPassword");

            migrationBuilder.RenameColumn(
                name: "CliApellidos",
                table: "Clientes",
                newName: "CliEmail");

            migrationBuilder.RenameColumn(
                name: "CliCorreo",
                table: "Clientes",
                newName: "CliID");

            migrationBuilder.RenameColumn(
                name: "CliCorreo",
                table: "Carritos",
                newName: "CliID");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_CliID",
                table: "Carritos",
                column: "CliID",
                unique: true,
                filter: "[CliID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Clientes_CliID",
                table: "Carritos",
                column: "CliID",
                principalTable: "Clientes",
                principalColumn: "CliID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Clientes_CliID",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_CliID",
                table: "Carritos");

            migrationBuilder.RenameColumn(
                name: "CliPassword",
                table: "Clientes",
                newName: "CliTelefono");

            migrationBuilder.RenameColumn(
                name: "CliEmail",
                table: "Clientes",
                newName: "CliApellidos");

            migrationBuilder.RenameColumn(
                name: "CliID",
                table: "Clientes",
                newName: "CliCorreo");

            migrationBuilder.RenameColumn(
                name: "CliID",
                table: "Carritos",
                newName: "CliCorreo");

            migrationBuilder.AddColumn<int>(
                name: "CliAntiguedad",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_CliCorreo",
                table: "Carritos",
                column: "CliCorreo",
                unique: true,
                filter: "[CliCorreo] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Clientes_CliCorreo",
                table: "Carritos",
                column: "CliCorreo",
                principalTable: "Clientes",
                principalColumn: "CliCorreo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
