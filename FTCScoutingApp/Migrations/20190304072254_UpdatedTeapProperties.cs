using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class UpdatedTeapProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasAutonomy",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Loses",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Ties",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "Wins",
                table: "Team",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "StartsLatched",
                table: "Team",
                newName: "TeamMarker");

            migrationBuilder.RenameColumn(
                name: "PrefersStartingCrater",
                table: "Team",
                newName: "Sampling");

            migrationBuilder.RenameColumn(
                name: "PlacesTeamMarker",
                table: "Team",
                newName: "Parking");

            migrationBuilder.RenameColumn(
                name: "ParksInCrater",
                table: "Team",
                newName: "Latched");

            migrationBuilder.RenameColumn(
                name: "MovesGoldMineral",
                table: "Team",
                newName: "Autonomy");

            migrationBuilder.RenameColumn(
                name: "KnownRobotProblems",
                table: "Team",
                newName: "TeamCountry");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Team",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndLocation",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartLocation",
                table: "Team",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "EndLocation",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "StartLocation",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "TeamMarker",
                table: "Team",
                newName: "StartsLatched");

            migrationBuilder.RenameColumn(
                name: "TeamCountry",
                table: "Team",
                newName: "KnownRobotProblems");

            migrationBuilder.RenameColumn(
                name: "Sampling",
                table: "Team",
                newName: "PrefersStartingCrater");

            migrationBuilder.RenameColumn(
                name: "Parking",
                table: "Team",
                newName: "PlacesTeamMarker");

            migrationBuilder.RenameColumn(
                name: "Latched",
                table: "Team",
                newName: "ParksInCrater");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "Team",
                newName: "Wins");

            migrationBuilder.RenameColumn(
                name: "Autonomy",
                table: "Team",
                newName: "MovesGoldMineral");

            migrationBuilder.AlterColumn<string>(
                name: "TeamID",
                table: "Team",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "HasAutonomy",
                table: "Team",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
