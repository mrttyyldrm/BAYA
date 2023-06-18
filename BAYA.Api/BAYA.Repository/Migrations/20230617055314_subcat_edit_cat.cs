using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAYA.Repository.Migrations
{
    /// <inheritdoc />
    public partial class subcat_edit_cat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "AidNotices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AidNotices_SubCategoryId",
                table: "AidNotices",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices");

            migrationBuilder.DropIndex(
                name: "IX_AidNotices_SubCategoryId",
                table: "AidNotices");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "AidNotices");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
