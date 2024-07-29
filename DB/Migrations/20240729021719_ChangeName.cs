using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class ChangeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beand_Beer_BrandId",
                table: "Beand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beer",
                table: "Beer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beand",
                table: "Beand");

            migrationBuilder.RenameTable(
                name: "Beer",
                newName: "Brands");

            migrationBuilder.RenameTable(
                name: "Beand",
                newName: "Beers");

            migrationBuilder.RenameIndex(
                name: "IX_Beand_BrandId",
                table: "Beers",
                newName: "IX_Beers_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beers",
                table: "Beers",
                column: "BeerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Brands_BrandId",
                table: "Beers",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Brands_BrandId",
                table: "Beers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beers",
                table: "Beers");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Beer");

            migrationBuilder.RenameTable(
                name: "Beers",
                newName: "Beand");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_BrandId",
                table: "Beand",
                newName: "IX_Beand_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beer",
                table: "Beer",
                column: "BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beand",
                table: "Beand",
                column: "BeerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beand_Beer_BrandId",
                table: "Beand",
                column: "BrandId",
                principalTable: "Beer",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
