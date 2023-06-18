using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAYA.Repository.Migrations
{
    /// <inheritdoc />
    public partial class aidnotice_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Counties_CountyId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Districts_DistrictId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Streets_StreetId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryId",
                table: "AidNotices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StreetId",
                table: "AidNotices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "AidNotices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "AidNotices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AidNotices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Counties_CountyId",
                table: "AidNotices",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Districts_DistrictId",
                table: "AidNotices",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Streets_StreetId",
                table: "AidNotices",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Categories_CategoryId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Counties_CountyId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Districts_DistrictId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_Streets_StreetId",
                table: "AidNotices");

            migrationBuilder.DropForeignKey(
                name: "FK_AidNotices_SubCategories_SubCategoryId",
                table: "AidNotices");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryId",
                table: "AidNotices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StreetId",
                table: "AidNotices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "AidNotices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountyId",
                table: "AidNotices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Counties_CountyId",
                table: "AidNotices",
                column: "CountyId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Districts_DistrictId",
                table: "AidNotices",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AidNotices_Streets_StreetId",
                table: "AidNotices",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
