using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_PageContents_Content_ID",
                table: "ContentComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "UserImage",
                table: "ContentComments");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "ContentComments");

            migrationBuilder.AddColumn<int>(
                name: "User_ID",
                table: "ContentComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_UserID",
                table: "Patrons",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContentComments_User_ID",
                table: "ContentComments",
                column: "User_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_PageContents_Content_ID",
                table: "ContentComments",
                column: "Content_ID",
                principalTable: "PageContents",
                principalColumn: "Content_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_User_User_ID",
                table: "ContentComments",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_User_UserID",
                table: "Patrons",
                column: "UserID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_PageContents_Content_ID",
                table: "ContentComments");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_User_User_ID",
                table: "ContentComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_User_UserID",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_UserID",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_ContentComments_User_ID",
                table: "ContentComments");

            migrationBuilder.DropColumn(
                name: "User_ID",
                table: "ContentComments");

            migrationBuilder.AddColumn<string>(
                name: "UserImage",
                table: "ContentComments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "ContentComments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_PageContents_Content_ID",
                table: "ContentComments",
                column: "Content_ID",
                principalTable: "PageContents",
                principalColumn: "Content_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
