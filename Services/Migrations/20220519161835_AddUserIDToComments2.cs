using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class AddUserIDToComments2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page");

            migrationBuilder.AddForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_User_User_ID",
                table: "Page");

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
