using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
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
                    ClosingPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingID);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    MeetingElementsId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Assignment = table.Column<string>(nullable: true),
                    HymnNumber = table.Column<int>(nullable: false),
                    MeetingID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Elements_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "MeetingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elements_MeetingID",
                table: "Elements",
                column: "MeetingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
