using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAYA.Repository.Migrations
{
    /// <inheritdoc />
    public partial class rechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices");

            migrationBuilder.DropIndex(
                name: "IX_AidNotices_SubCategoryId",
                table: "AidNotices");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "AidNotices");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AidNotices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AidNotices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
