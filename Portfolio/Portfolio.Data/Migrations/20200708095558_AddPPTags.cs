using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Data.Migrations
{
    public partial class AddPPTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PersonalProjectTags_PersonalProjectId",
                table: "PersonalProjectTags",
                column: "PersonalProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalProjectTags");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
