using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Country", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Denmark", "A modern hotel in the heart of Copenhagen.", "/images/Copenhagen5.jpg", "Hotel Copenhagen" },
                    { 2, "Denmark", "A cozy hotel in Aarhus.", "/images/Aarhus.jpg", "Hotel Aarhus" },
                    { 3, "Germany", "An upscale hotel near Brandenburg Gate.", "https://via.placeholder.com/150", "Hotel Berlin" },
                    { 4, "Germany", "A charming hotel in Munich.", "https://via.placeholder.com/150", "Hotel Munich" },
                    { 5, "France", "A romantic hotel with views of the Eiffel Tower.", "https://via.placeholder.com/150", "Hotel Paris" },
                    { 6, "France", "A beautiful hotel in Lyon.", "https://via.placeholder.com/150", "Hotel Lyon" },
                    { 7, "Italy", "A charming hotel in the city center.", "https://via.placeholder.com/150", "Hotel Rome" },
                    { 8, "Italy", "A stylish hotel in Milan.", "https://via.placeholder.com/150", "Hotel Milan" },
                    { 9, "Spain", "A vibrant hotel near the beach.", "https://via.placeholder.com/150", "Hotel Barcelona" },
                    { 10, "Spain", "A luxurious hotel in Madrid.", "https://via.placeholder.com/150", "Hotel Madrid" },
                    { 11, "UK", "A luxurious hotel in the capital.", "https://via.placeholder.com/150", "Hotel London" },
                    { 12, "UK", "A modern hotel in Manchester.", "https://via.placeholder.com/150", "Hotel Manchester" },
                    { 13, "USA", "A stylish hotel in the city.", "https://via.placeholder.com/150", "Hotel New York" },
                    { 14, "USA", "A luxurious hotel in Los Angeles.", "https://via.placeholder.com/150", "Hotel Los Angeles" },
                    { 15, "Canada", "A modern hotel in the heart of the city.", "https://via.placeholder.com/150", "Hotel Toronto" },
                    { 16, "Canada", "A beautiful hotel in Vancouver.", "https://via.placeholder.com/150", "Hotel Vancouver" },
                    { 17, "Australia", "A luxury hotel with views of the harbor.", "https://via.placeholder.com/150", "Hotel Sydney" },
                    { 18, "Australia", "A stylish hotel in Melbourne.", "https://via.placeholder.com/150", "Hotel Melbourne" },
                    { 19, "Japan", "A high-tech hotel in the city.", "https://via.placeholder.com/150", "Hotel Tokyo" },
                    { 20, "Japan", "A traditional hotel in Kyoto.", "https://via.placeholder.com/150", "Hotel Kyoto" },
                    { 21, "Brazil", "A beachfront hotel in Brazil.", "https://via.placeholder.com/150", "Hotel Rio de Janeiro" },
                    { 22, "Brazil", "A modern hotel in Sao Paulo.", "https://via.placeholder.com/150", "Hotel Sao Paulo" },
                    { 23, "China", "A historical hotel in China.", "https://via.placeholder.com/150", "Hotel Beijing" },
                    { 24, "China", "A luxurious hotel in Shanghai.", "https://via.placeholder.com/150", "Hotel Shanghai" },
                    { 25, "India", "A luxurious hotel in India.", "https://via.placeholder.com/150", "Hotel Mumbai" },
                    { 26, "India", "A modern hotel in Delhi.", "https://via.placeholder.com/150", "Hotel Delhi" },
                    { 27, "Russia", "A stylish hotel in the capital.", "https://via.placeholder.com/150", "Hotel Moscow" },
                    { 28, "Russia", "A beautiful hotel in Saint Petersburg.", "https://via.placeholder.com/150", "Hotel Saint Petersburg" },
                    { 29, "South Africa", "A hotel with stunning views.", "https://via.placeholder.com/150", "Hotel Cape Town" },
                    { 30, "South Africa", "A modern hotel in Johannesburg.", "https://via.placeholder.com/150", "Hotel Johannesburg" },
                    { 31, "Egypt", "A hotel near the pyramids.", "https://via.placeholder.com/150", "Hotel Cairo" },
                    { 32, "Egypt", "A beautiful hotel in Alexandria.", "https://via.placeholder.com/150", "Hotel Alexandria" },
                    { 33, "Argentina", "A vibrant hotel in Argentina.", "https://via.placeholder.com/150", "Hotel Buenos Aires" },
                    { 34, "Argentina", "A charming hotel in Cordoba.", "https://via.placeholder.com/150", "Hotel Cordoba" },
                    { 35, "Mexico", "A modern hotel in the capital.", "https://via.placeholder.com/150", "Hotel Mexico City" },
                    { 36, "Mexico", "A beachfront hotel in Cancun.", "https://via.placeholder.com/150", "Hotel Cancun" },
                    { 37, "Turkey", "A historic hotel in the city.", "https://via.placeholder.com/150", "Hotel Istanbul" },
                    { 38, "Turkey", "A modern hotel in Ankara.", "https://via.placeholder.com/150", "Hotel Ankara" },
                    { 39, "Greece", "A hotel with stunning views of the Acropolis.", "https://via.placeholder.com/150", "Hotel Athens" },
                    { 40, "Greece", "A charming hotel in Thessaloniki.", "https://via.placeholder.com/150", "Hotel Thessaloniki" },
                    { 41, "Portugal", "A charming hotel in Portugal.", "https://via.placeholder.com/150", "Hotel Lisbon" },
                    { 42, "Portugal", "A beautiful hotel in Porto.", "https://via.placeholder.com/150", "Hotel Porto" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
