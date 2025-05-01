using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddPrixToProduit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prix",
                table: "Produits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Produits");
        }
    }
}
