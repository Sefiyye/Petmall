using Microsoft.EntityFrameworkCore.Migrations;

namespace Petmall_Back_End.Migrations
{
    public partial class addIconDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Icons");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Icons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Icons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Icons");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Icons");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Icons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
