using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class RenameDiscriminator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "TPHCursussen",
                newName: "CursusType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CursusType",
                table: "TPHCursussen",
                newName: "Discriminator");
        }
    }
}
