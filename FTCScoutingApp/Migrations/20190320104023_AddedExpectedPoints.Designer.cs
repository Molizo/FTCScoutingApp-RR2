﻿// <auto-generated />
using FTCScoutingApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FTCScoutingApp.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20190320104023_AddedExpectedPoints")]
    partial class AddedExpectedPoints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FTCScoutingApp.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventName");

                    b.Property<string>("GamesPlayed");

                    b.Property<int>("MatchesPlayed");

                    b.HasKey("ID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("FTCScoutingApp.Models.Match", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlueAllianceScore");

                    b.Property<string>("BlueTeam1ID");

                    b.Property<string>("BlueTeam2ID");

                    b.Property<int>("RedAllianceScore");

                    b.Property<string>("RedTeam1ID");

                    b.Property<string>("RedTeam2ID");

                    b.HasKey("ID");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("FTCScoutingApp.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllowedUserIDs");

                    b.Property<bool>("Autonomy");

                    b.Property<string>("Comments");

                    b.Property<int>("DepotMinerals");

                    b.Property<string>("EndLocation");

                    b.Property<int>("EventID");

                    b.Property<int>("ExPts");

                    b.Property<int>("GoldMinerals");

                    b.Property<bool>("Latched");

                    b.Property<int>("Loses");

                    b.Property<bool>("Parking");

                    b.Property<bool>("Sampling");

                    b.Property<int>("SilverMinerals");

                    b.Property<string>("StartLocation");

                    b.Property<string>("TeamCountry");

                    b.Property<int>("TeamID");

                    b.Property<bool>("TeamMarker");

                    b.Property<string>("TeamName");

                    b.Property<int>("Ties");

                    b.Property<int>("Wins");

                    b.HasKey("ID");

                    b.ToTable("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
