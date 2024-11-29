using Microsoft.EntityFrameworkCore.Migrations;

namespace CarrilloShop2.Migrations
{
    public partial class avansandosenores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Clientes_CliID",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_CliID",
                table: "Carritos");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CliID",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CliID",
                table: "Carritos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarritoID",
                table: "Carritos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_CliID",
                table: "Carritos",
                column: "CliID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Clientes_CliID",
                table: "Carritos",
                column: "CliID",
                principalTable: "Clientes",
                principalColumn: "CliID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Clientes_CliID",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_CliID",
                table: "Carritos");

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Productos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CliID",
                table: "Clientes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CliID",
                table: "Carritos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CarritoID",
                table: "Carritos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
    }
}
