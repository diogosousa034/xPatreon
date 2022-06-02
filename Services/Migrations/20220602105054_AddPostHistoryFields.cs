using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class AddPostHistoryFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "PostHistory",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "PostHistory",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "PostHistory",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainContent",
                table: "PostHistory",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublicationData",
                table: "PostHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PostHistory",
                type: "nvarchar(150)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "PostHistory");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "PostHistory");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "PostHistory");

            migrationBuilder.DropColumn(
                name: "MainContent",
                table: "PostHistory");

            migrationBuilder.DropColumn(
                name: "PublicationData",
                table: "PostHistory");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "PostHistory");
        }
    }
}
