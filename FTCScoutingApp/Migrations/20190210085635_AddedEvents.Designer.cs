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
    [Migration("20190210085635_AddedEvents")]
    partial class AddedEvents
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
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

            modelBuilder.Entity("FTCScoutingApp.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllowedUserIDs");

                    b.Property<bool>("HasAutonomy");

                    b.Property<string>("KnownRobotProblems");

                    b.Property<int>("Loses");

                    b.Property<bool>("MovesGoldMineral");

                    b.Property<bool>("ParksInCrater");

                    b.Property<bool>("PlacesTeamMarker");

                    b.Property<bool>("PrefersStartingCrater");

                    b.Property<bool>("StartsLatched");

                    b.Property<string>("TeamID");

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
