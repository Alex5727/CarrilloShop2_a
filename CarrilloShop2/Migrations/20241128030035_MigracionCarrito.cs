using Microsoft.EntityFrameworkCore.Migrations;

namespace CarrilloShop2.Migrations
{
    public partial class MigracionCarrito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carritos",
                columns: table => new
                {
                    CarritoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CliCorreo = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carritos", x => x.CarritoID);
                    table.ForeignKey(
                        name: "FK_Carritos_Clientes_CliCorreo",
                        column: x => x.CliCorreo,
                        principalTable: "Clientes",
                        principalColumn: "CliCorreo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_CliCorreo",
                table: "Carritos",
                column: "CliCorreo",
                unique: true,
                filter: "[CliCorreo] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carritos");
        }
    }
}
