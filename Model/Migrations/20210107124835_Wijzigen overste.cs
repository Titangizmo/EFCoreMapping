using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Wijzigenoverste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssWerknemers_AssWerknemers_OversteWerknemerId",
                table: "AssWerknemers");

            migrationBuilder.RenameColumn(
                name: "OversteWerknemerId",
                table: "AssWerknemers",
                newName: "OversteId");

            migrationBuilder.RenameIndex(
                name: "IX_AssWerknemers_OversteWerknemerId",
                table: "AssWerknemers",
                newName: "IX_AssWerknemers_OversteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssWerknemers_AssWerknemers_OversteId",
                table: "AssWerknemers",
                column: "OversteId",
                principalTable: "AssWerknemers",
                principalColumn: "WerknemerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssWerknemers_AssWerknemers_OversteId",
                table: "AssWerknemers");

            migrationBuilder.RenameColumn(
                name: "OversteId",
                table: "AssWerknemers",
                newName: "OversteWerknemerId");

            migrationBuilder.RenameIndex(
                name: "IX_AssWerknemers_OversteId",
                table: "AssWerknemers",
                newName: "IX_AssWerknemers_OversteWerknemerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssWerknemers_AssWerknemers_OversteWerknemerId",
                table: "AssWerknemers",
                column: "OversteWerknemerId",
                principalTable: "AssWerknemers",
                principalColumn: "WerknemerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
