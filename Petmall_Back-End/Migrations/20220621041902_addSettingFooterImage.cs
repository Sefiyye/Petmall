using Microsoft.EntityFrameworkCore.Migrations;

namespace Petmall_Back_End.Migrations
{
    public partial class addSettingFooterImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterImage",
                table: "Settings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterImage",
                table: "Settings");
        }
    }
}
