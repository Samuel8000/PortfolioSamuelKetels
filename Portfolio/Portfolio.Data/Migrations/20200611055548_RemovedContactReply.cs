using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class RemovedContactReply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactReplied",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DateReplied",
                table: "Contacts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ContactReplied",
                table: "Contacts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplied",
                table: "Contacts",
                type: "datetime2",
                nullable: true);
        }
    }
}
