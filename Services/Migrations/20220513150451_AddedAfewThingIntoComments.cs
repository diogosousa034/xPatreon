using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class AddedAfewThingIntoComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserImage",
                table: "ContentComments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "ContentComments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserImage",
                table: "ContentComments");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "ContentComments");
        }
    }
}
