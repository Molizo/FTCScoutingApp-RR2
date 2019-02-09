using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class AddedteamIDfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamID",
                table: "Team",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Team");
        }
    }
}
