using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class AddedWLTtoTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "Loses",
                "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                "Ties",
                "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                "Wins",
                "Team",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Loses",
                "Team");

            migrationBuilder.DropColumn(
                "Ties",
                "Team");

            migrationBuilder.DropColumn(
                "Wins",
                "Team");
        }
    }
}