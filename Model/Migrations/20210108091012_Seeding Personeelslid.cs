using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class SeedingPersoneelslid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeelsleden",
                columns: table => new
                {
                    PersoneelsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeelsleden", x => x.PersoneelsId);
                    table.ForeignKey(
                        name: "FK_PersoneelManager",
                        column: x => x.ManagerId,
                        principalTable: "Personeelsleden",
                        principalColumn: "PersoneelsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personeelsleden_ManagerId",
                table: "Personeelsleden",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeelsleden");
        }
    }
}
