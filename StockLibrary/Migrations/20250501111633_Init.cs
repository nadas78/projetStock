using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_CategorieId",
                table: "Produits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produits",
                table: "Produits");

            migrationBuilder.RenameTable(
                name: "Produits",
                newName: "Produit");

            migrationBuilder.RenameIndex(
                name: "IX_Produits_CategorieId",
                table: "Produit",
                newName: "IX_Produit_CategorieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produit",
                table: "Produit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_Categories_CategorieId",
                table: "Produit",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produit_Categories_CategorieId",
                table: "Produit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produit",
                table: "Produit");

            migrationBuilder.RenameTable(
                name: "Produit",
                newName: "Produits");

            migrationBuilder.RenameIndex(
                name: "IX_Produit_CategorieId",
                table: "Produits",
                newName: "IX_Produits_CategorieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produits",
                table: "Produits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_CategorieId",
                table: "Produits",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
