using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddedSkillPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillPaths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillPathName = table.Column<string>(nullable: true),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPaths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillPaths_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { "NoCertificate.pdf", new DateTime(2020, 8, 12, 10, 36, 2, 537, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { "NoCertificate.pdf", new DateTime(2020, 8, 12, 10, 36, 2, 540, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { "NoCertificate.pdf", new DateTime(2020, 8, 12, 10, 36, 2, 540, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.CreateIndex(
                name: "IX_SkillPaths_SkillId",
                table: "SkillPaths",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillPaths");

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { null, new DateTime(2020, 8, 11, 13, 12, 5, 843, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { null, new DateTime(2020, 8, 11, 13, 12, 5, 845, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { null, new DateTime(2020, 8, 11, 13, 12, 5, 845, DateTimeKind.Local).AddTicks(9839) });
        }
    }
}
