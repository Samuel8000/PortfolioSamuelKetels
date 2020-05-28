using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(nullable: false),
                    SkillDescription = table.Column<string>(maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(nullable: true),
                    PsDescription = table.Column<string>(nullable: true),
                    PsSkillIqScore = table.Column<int>(nullable: false),
                    PsChartFilePath = table.Column<string>(nullable: true),
                    PsSkillLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "LogoFilePath", "PsChartFilePath", "PsDescription", "PsSkillIqScore", "PsSkillLevel", "SkillDescription", "SkillName" },
                values: new object[] { 1, "html5logo.png", "HTMLSkillIQ.png", "Summary of courses followed", 230, 3, "Personal Description and evaluation", "HTML5" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "LogoFilePath", "PsChartFilePath", "PsDescription", "PsSkillIqScore", "PsSkillLevel", "SkillDescription", "SkillName" },
                values: new object[] { 2, "css3logo.png", "CSSSkillIQ.png", "Summary of courses followed", 198, 2, "Personal Description and evaluation", "CSS3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
