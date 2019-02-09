using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true),
                    Wins = table.Column<int>(nullable: false),
                    Loses = table.Column<int>(nullable: false),
                    Ties = table.Column<int>(nullable: false),
                    StartsLatched = table.Column<bool>(nullable: false),
                    PrefersStartingCrater = table.Column<bool>(nullable: false),
                    KnownRobotProblems = table.Column<string>(nullable: true),
                    HasAutonomy = table.Column<bool>(nullable: false),
                    MovesGoldMineral = table.Column<bool>(nullable: false),
                    PlacesTeamMarker = table.Column<bool>(nullable: false),
                    ParksInCrater = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
