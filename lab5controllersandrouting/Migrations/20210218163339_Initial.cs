using Microsoft.EntityFrameworkCore.Migrations;

namespace lab5controllersandrouting.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "FAQs");

            migrationBuilder.AlterColumn<string>(
                name: "TopicId",
                table: "FAQs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "FAQs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "hist", "cs" });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_FAQs_Categories_CategoryId",
                table: "FAQs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FAQs_Topics_TopicId",
                table: "FAQs",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FAQs_Categories_CategoryId",
                table: "FAQs");

            migrationBuilder.DropForeignKey(
                name: "FK_FAQs_Topics_TopicId",
                table: "FAQs");

            migrationBuilder.DropIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs");

            migrationBuilder.DropIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs");

            migrationBuilder.AlterColumn<string>(
                name: "TopicId",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "TopicId" },
                values: new object[] { "gen", "boot" });
        }
    }
}
