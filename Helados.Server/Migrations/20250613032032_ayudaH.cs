using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
//Marcus Montilla 2024-1783


namespace Helados.Server.Migrations
{
    /// <inheritdoc />
    public partial class ayudaH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeladosV3",
                table: "HeladosV3");

            migrationBuilder.RenameTable(
                name: "HeladosV3",
                newName: "Helados");

            migrationBuilder.RenameIndex(
                name: "IX_HeladosV3_Nombre",
                table: "Helados",
                newName: "IX_Helados_Nombre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Helados",
                table: "Helados",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Helados",
                table: "Helados");

            migrationBuilder.RenameTable(
                name: "Helados",
                newName: "HeladosV3");

            migrationBuilder.RenameIndex(
                name: "IX_Helados_Nombre",
                table: "HeladosV3",
                newName: "IX_HeladosV3_Nombre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeladosV3",
                table: "HeladosV3",
                column: "Id");
        }
    }
}
