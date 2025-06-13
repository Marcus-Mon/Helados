using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Helados.Server.Migrations
{
    /// <inheritdoc />
    public partial class Helados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Helados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sabor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helados", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Helados_Nombre",
                table: "Helados",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Helados");
        }
    }
}
