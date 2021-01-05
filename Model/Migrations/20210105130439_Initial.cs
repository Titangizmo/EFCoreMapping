using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campussen",
                columns: table => new
                {
                    CampusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Straat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuisNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campussen", x => x.CampusId);
                });

            migrationBuilder.CreateTable(
                name: "Docenten",
                columns: table => new
                {
                    DocentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Familienaam = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Maandwedde = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    HeeftRijbewijs = table.Column<bool>(type: "bit", nullable: true),
                    LandCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InDienst = table.Column<DateTime>(type: "date", nullable: false),
                    StraatThuis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuisNrThuis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCdThuis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GemeenteThuis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StraatWerk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuisNrWerk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCdWerk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GemeenteWerk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docenten", x => x.DocentId);
                    table.ForeignKey(
                        name: "FK_Docenten_Campussen_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campussen",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docenten_CampusId",
                table: "Docenten",
                column: "CampusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docenten");

            migrationBuilder.DropTable(
                name: "Campussen");
        }
    }
}
