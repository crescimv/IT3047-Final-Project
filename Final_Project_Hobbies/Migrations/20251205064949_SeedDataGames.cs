using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project_Hobbies.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "Battle Royale", "Apex Legends" },
                    { 2, "Strategy", "Bloons TD" },
                    { 3, "Action-RPG", "Elden Ring" },
                    { 4, "Metroidvania", "Hollow Knight" },
                    { 5, "Metroidvania", "Hollow Knight: Silksong" },
                    { 6, "Sandbox", "Minecraft" },
                    { 7, "Open World", "Subnautica" },
                    { 8, "Open World", "Subnautica: Below Zero" },
                    { 9, "Platformer", "Super Mario Galaxy" },
                    { 10, "Platformer", "Super Mario Galaxy 2" },
                    { 11, "Platformer", "Super Paper Mario" },
                    { 12, "Action", "Sekiro" },
                    { 13, "Simulation", "Stardew Valley" },
                    { 14, "Sandbox", "Terraria" },
                    { 15, "Action-Adventure", "The Legend of Zelda: Breath of the Wild" },
                    { 16, "Action-Adventure", "The Legend of Zelda: Skyward Sword" },
                    { 17, "Action-Adventure", "The Legend of Zelda: Windwaker" },
                    { 18, "Simulation", "PowerWash Simulator" },
                    { 19, "Sports", "PGA Tour" },
                    { 20, "RPG", "Pokemon" },
                    { 21, "First-Person Shooter", "Halo" },
                    { 22, "First-Person Shooter", "Call of Duty" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
