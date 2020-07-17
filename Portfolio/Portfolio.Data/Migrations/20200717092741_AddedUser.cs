using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "LogoFilePath", "PsChartFilePath", "PsDescription", "PsSkillIqScore", "PsSkillLevel", "SkillDescription", "SkillName" },
                values: new object[] { 1, "html5logo.png", "HTMLSkillIQ.png", "Summary of courses followed", 230, 3, "Personal Description and evaluation", "HTML5" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "LogoFilePath", "PsChartFilePath", "PsDescription", "PsSkillIqScore", "PsSkillLevel", "SkillDescription", "SkillName" },
                values: new object[] { 2, "css3logo.png", "CSSSkillIQ.png", "Summary of courses followed", 198, 2, "Personal Description and evaluation", "CSS3" });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateDescription", "CertificateFileName", "CertificateName", "SkillId" },
                values: new object[] { 1, "Basics of HTML5", null, "HTML5 Fundamentals", 1 });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateDescription", "CertificateFileName", "CertificateName", "SkillId" },
                values: new object[] { 2, "Basics of CSS3", null, "Introduction to CSS", 2 });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CertificateDescription", "CertificateFileName", "CertificateName", "SkillId" },
                values: new object[] { 3, "Basics of CSS3", null, "Your First Day with CSS", 2 });
        }
    }
}
