using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class addContents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserContents",
                columns: table => new
                {
                    Content_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    MainContent = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    User_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContents", x => x.Content_ID);
                    table.ForeignKey(
                        name: "FK_UserContents_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserContents_User_ID",
                table: "UserContents",
                column: "User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserContents");
        }
    }
}
