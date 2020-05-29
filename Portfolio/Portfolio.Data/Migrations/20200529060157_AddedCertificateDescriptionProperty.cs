using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddedCertificateDescriptionProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificateDescription",
                table: "Certificates",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CertificateDescription",
                value: "Basics of HTML5");

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CertificateDescription",
                value: "Basics of CSS3");

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CertificateDescription",
                value: "Basics of CSS3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificateDescription",
                table: "Certificates");
        }
    }
}
