using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class teste234534563452 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostHistory_PageContents_PostHistory_ID",
                table: "PostHistory");

            migrationBuilder.CreateIndex(
                name: "IX_PostHistory_PageContent_ID",
                table: "PostHistory",
                column: "PageContent_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PostHistory_PageContents_PageContent_ID",
                table: "PostHistory",
                column: "PageContent_ID",
                principalTable: "PageContents",
                principalColumn: "Content_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostHistory_PageContents_PageContent_ID",
                table: "PostHistory");

            migrationBuilder.DropIndex(
                name: "IX_PostHistory_PageContent_ID",
                table: "PostHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_PostHistory_PageContents_PostHistory_ID",
                table: "PostHistory",
                column: "PostHistory_ID",
                principalTable: "PageContents",
                principalColumn: "Content_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
