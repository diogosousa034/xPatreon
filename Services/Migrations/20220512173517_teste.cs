using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    RegistrationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Page_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    CreatingWhat = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    IsAreCreating = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    active = table.Column<bool>(nullable: false),
                    AboutPage = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    PageCreationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Page_ID);
                    table.ForeignKey(
                        name: "FK_Page_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageContents",
                columns: table => new
                {
                    Content_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    MainContent = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PublicationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Page_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageContents", x => x.Content_ID);
                    table.ForeignKey(
                        name: "FK_PageContents_Page_Page_ID",
                        column: x => x.Page_ID,
                        principalTable: "Page",
                        principalColumn: "Page_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    PatronFollow_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Page_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.PatronFollow_ID);
                    table.ForeignKey(
                        name: "FK_Patrons_Page_Page_ID",
                        column: x => x.Page_ID,
                        principalTable: "Page",
                        principalColumn: "Page_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentComments",
                columns: table => new
                {
                    Comment_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CommentData = table.Column<DateTime>(nullable: false),
                    Content_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentComments", x => x.Comment_ID);
                    table.ForeignKey(
                        name: "FK_ContentComments_PageContents_Content_ID",
                        column: x => x.Content_ID,
                        principalTable: "PageContents",
                        principalColumn: "Content_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentComments_Content_ID",
                table: "ContentComments",
                column: "Content_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Page_PageName",
                table: "Page",
                column: "PageName",
                unique: true,
                filter: "[PageName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Page_User_ID",
                table: "Page",
                column: "User_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_Page_ID",
                table: "PageContents",
                column: "Page_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_Page_ID",
                table: "Patrons",
                column: "Page_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentComments");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropTable(
                name: "PageContents");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
