using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class AddedWLTtoTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Loses",
                table: "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ties",
                table: "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "Team",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loses",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Ties",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Team");
        }
    }
}
