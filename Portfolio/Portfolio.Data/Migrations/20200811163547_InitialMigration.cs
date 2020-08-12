using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillPath",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillPathName = table.Column<string>(nullable: true),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPath", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillPath_Skills_SkillId",
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
                values: new object[] { "NoCertificate.pdf", new DateTime(2020, 8, 11, 18, 35, 46, 89, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { "NoCertificate.pdf", new DateTime(2020, 8, 11, 18, 35, 46, 95, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CertificateFileName", "DateCompleted" },
                values: new object[] { "NoCertificate.pdf", new DateTime(2020, 8, 11, 18, 35, 46, 95, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.CreateIndex(
                name: "IX_SkillPath_SkillId",
                table: "SkillPath",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillPath");

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
