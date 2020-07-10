using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactFirstName = table.Column<string>(nullable: true),
                    ContactLastName = table.Column<string>(nullable: true),
                    ContactEmailAddress = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    ContactOption = table.Column<int>(nullable: false),
                    ContactType = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    DateContacted = table.Column<DateTime>(nullable: false),
                    ContactPhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromAddress = table.Column<string>(nullable: false),
                    FromName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FccProjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FccProjectName = table.Column<string>(nullable: true),
                    FccProjectDescription = table.Column<string>(nullable: true),
                    FccProjectLink = table.Column<string>(nullable: true),
                    FccProjectThumb = table.Column<string>(nullable: true),
                    CodeLink = table.Column<string>(nullable: true),
                    FccCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FccProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: false),
                    ProjectDescription = table.Column<string>(nullable: true),
                    ProjectThumb = table.Column<string>(nullable: true),
                    DateCompleted = table.Column<DateTime>(nullable: false),
                    CodeLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "PersonalProjectTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag1 = table.Column<int>(nullable: false),
                    Tag2 = table.Column<int>(nullable: false),
                    Tag3 = table.Column<int>(nullable: false),
                    Tag4 = table.Column<int>(nullable: false),
                    Tag5 = table.Column<int>(nullable: false),
                    PersonalProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalProjectTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalProjectTags_Projects_PersonalProjectId",
                        column: x => x.PersonalProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(nullable: true),
                    CertificateDescription = table.Column<string>(nullable: true),
                    CertificateFileName = table.Column<string>(nullable: true),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_SkillId",
                table: "Certificates",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalProjectTags_PersonalProjectId",
                table: "PersonalProjectTags",
                column: "PersonalProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EmailSettings");

            migrationBuilder.DropTable(
                name: "FccProjects");

            migrationBuilder.DropTable(
                name: "PersonalProjectTags");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
