using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class SeedingPersoneelslid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsId", "ManagerId", "Voornaam" },
                values: new object[] { 1, null, "Diane" });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsId", "ManagerId", "Voornaam" },
                values: new object[] { 2, 1, "Mary" });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsId", "ManagerId", "Voornaam" },
                values: new object[] { 3, 1, "Jeff" });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsId", "ManagerId", "Voornaam" },
                values: new object[,]
                {
                    { 4, 2, "William" },
                    { 5, 2, "Gerard" },
                    { 6, 2, "Anthony" },
                    { 19, 2, "Mami" }
                });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsId", "ManagerId", "Voornaam" },
                values: new object[,]
                {
                    { 16, 4, "Andy" },
                    { 17, 4, "Peter" },
                    { 18, 4, "Tom" },
                    { 12, 5, "Loui" },
                    { 13, 5, "Pamela" },
                    { 14, 5, "Larry" },
                    { 15, 5, "Barry" },
                    { 21, 5, "Martin" },
                    { 7, 6, "Leslie" },
                    { 8, 6, "July" },
                    { 9, 6, "Steve" },
                    { 10, 6, "Foon Yue" },
                    { 11, 6, "George" },
                    { 20, 19, "Yoshimi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personeelsleden",
                keyColumn: "PersoneelsId",
                keyValue: 1);
        }
    }
}
