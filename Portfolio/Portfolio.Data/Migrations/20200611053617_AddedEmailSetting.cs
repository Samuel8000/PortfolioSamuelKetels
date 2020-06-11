using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddedEmailSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Replied",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Contacts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ContactReplied",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplied",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Replied",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
