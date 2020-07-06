using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddedCodeLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeLink",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodeLink",
                table: "FccProjects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeLink",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CodeLink",
                table: "FccProjects");
        }
    }
}
