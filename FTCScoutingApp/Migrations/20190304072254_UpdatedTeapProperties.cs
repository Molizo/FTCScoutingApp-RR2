using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class UpdatedTeapProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "HasAutonomy",
                "Team");

            migrationBuilder.DropColumn(
                "Loses",
                "Team");

            migrationBuilder.DropColumn(
                "Ties",
                "Team");

            migrationBuilder.RenameColumn(
                "Wins",
                "Team",
                "EventID");

            migrationBuilder.RenameColumn(
                "StartsLatched",
                "Team",
                "TeamMarker");

            migrationBuilder.RenameColumn(
                "PrefersStartingCrater",
                "Team",
                "Sampling");

            migrationBuilder.RenameColumn(
                "PlacesTeamMarker",
                "Team",
                "Parking");

            migrationBuilder.RenameColumn(
                "ParksInCrater",
                "Team",
                "Latched");

            migrationBuilder.RenameColumn(
                "MovesGoldMineral",
                "Team",
                "Autonomy");

            migrationBuilder.RenameColumn(
                "KnownRobotProblems",
                "Team",
                "TeamCountry");

            migrationBuilder.AlterColumn<int>(
                "TeamID",
                "Team",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                "Comments",
                "Team",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "EndLocation",
                "Team",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "StartLocation",
                "Team",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Comments",
                "Team");

            migrationBuilder.DropColumn(
                "EndLocation",
                "Team");

            migrationBuilder.DropColumn(
                "StartLocation",
                "Team");

            migrationBuilder.RenameColumn(
                "TeamMarker",
                "Team",
                "StartsLatched");

            migrationBuilder.RenameColumn(
                "TeamCountry",
                "Team",
                "KnownRobotProblems");

            migrationBuilder.RenameColumn(
                "Sampling",
                "Team",
                "PrefersStartingCrater");

            migrationBuilder.RenameColumn(
                "Parking",
                "Team",
                "PlacesTeamMarker");

            migrationBuilder.RenameColumn(
                "Latched",
                "Team",
                "ParksInCrater");

            migrationBuilder.RenameColumn(
                "EventID",
                "Team",
                "Wins");

            migrationBuilder.RenameColumn(
                "Autonomy",
                "Team",
                "MovesGoldMineral");

            migrationBuilder.AlterColumn<string>(
                "TeamID",
                "Team",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                "HasAutonomy",
                "Team",
                nullable: false,
                defaultValue: false);

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
        }
    }
}