using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class AddPostHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostHistory",
                columns: table => new
                {
                    PostHistory_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageContent_ID = table.Column<int>(nullable: false),
                    DateOfChange = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostHistory", x => x.PostHistory_ID);
                    table.ForeignKey(
                        name: "FK_PostHistory_PageContents_PostHistory_ID",
                        column: x => x.PostHistory_ID,
                        principalTable: "PageContents",
                        principalColumn: "Content_ID",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostHistory");
        }
    }
}
