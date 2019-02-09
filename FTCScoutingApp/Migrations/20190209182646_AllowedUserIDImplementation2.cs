using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class AllowedUserIDImplementation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AllowedUserIDs",
                table: "Team",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowedUserIDs",
                table: "Team");
        }
    }
}
