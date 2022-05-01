using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class AddDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(30)", nullable: false),
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
                    PageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CreatingWhat = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IsAreCreating = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Patrons = table.Column<int>(nullable: false),
                    active = table.Column<bool>(nullable: false),
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
                    Title = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    MainContent = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PublicationData = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Page_User_ID",
                table: "Page",
                column: "User_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_Page_ID",
                table: "PageContents",
                column: "Page_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageContents");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
