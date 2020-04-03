using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class FirstSpeaker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetingID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Conducting = table.Column<string>(nullable: true),
                    OpeningHymnNumber = table.Column<int>(nullable: false),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    OpeningHymn = table.Column<string>(nullable: true),
                    SacramentHymnNumber = table.Column<int>(nullable: false),
                    SacramentHymn = table.Column<string>(nullable: true),
                    ClosingHymnNumber = table.Column<int>(nullable: false),
                    ClosingHymn = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true),
                    FirstSpeaker = table.Column<string>(nullable: true),
                    SecondSpeaker = table.Column<string>(nullable: true),
                    IntermediateHymnNumber = table.Column<int>(nullable: false),
                    IntermediateHymn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
