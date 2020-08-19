using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class SkillPathVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCompleted",
                value: new DateTime(2020, 8, 19, 8, 34, 26, 238, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCompleted",
                value: new DateTime(2020, 8, 19, 8, 34, 26, 246, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCompleted",
                value: new DateTime(2020, 8, 19, 8, 34, 26, 246, DateTimeKind.Local).AddTicks(1018));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCompleted",
                value: new DateTime(2020, 8, 12, 10, 36, 2, 537, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCompleted",
                value: new DateTime(2020, 8, 12, 10, 36, 2, 540, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCompleted",
                value: new DateTime(2020, 8, 12, 10, 36, 2, 540, DateTimeKind.Local).AddTicks(7399));
        }
    }
}
