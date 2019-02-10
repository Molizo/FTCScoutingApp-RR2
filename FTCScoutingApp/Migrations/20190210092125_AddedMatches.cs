using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FTCScoutingApp.Migrations
{
    public partial class AddedMatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlueAllianceScore = table.Column<int>(nullable: false),
                    RedAllianceScore = table.Column<int>(nullable: false),
                    BlueTeam1ID = table.Column<string>(nullable: true),
                    BlueTeam2ID = table.Column<string>(nullable: true),
                    RedTeam1ID = table.Column<string>(nullable: true),
                    RedTeam2ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match");
        }
    }
}
