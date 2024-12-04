using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameHotelColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Domain = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    SecurityLevel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelName = table.Column<string>(type: "TEXT", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Country", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Denmark", "Experience Legoland in Billund", "/images/legolegolego.jpeg", "Legoland" },
                    { 2, "Denmark", "Experience Tivoli in Copenhagen", "/images/kbhtivoli.jpg", "Tivoli" },
                    { 3, "Denmark", "Experience Kongelig teater in Copenhagen", "/images/kongeligeteaterrrr.jpg", "Kongelige teater" },
                    { 4, "Denmark", "Experience Jellingestenen in Sydjylland", "/images/jellingsteeen.jpg", "Jellingestenen" },
                    { 5, "Germany", "Experience Europa-Park and its exciting roller coasters", "/images/Rust1.jpg", "Europa-Park" },
                    { 6, "Germany", "Experience a beautiful and peaceful park in North Germany", "/images/Goslar.jpg", "Nationalpark Harz" },
                    { 7, "France", "Experience the amazing view of the Eiffel Tower.", "/images/Paris.jpg", "Eiffel Tower" },
                    { 8, "France", "Experience a tasteful wine tour in Bordeaux", "/images/Bordeaux.jpg", "Wine Tour" },
                    { 9, "Canada", "Experience the massive waterfall Niagara Falls in Ontario", "/images/Ontario.jpg", "Niagara Falls" },
                    { 10, "Canada", "Experience Canada's oldest national park Banff", "/images/Alberta.jpg", "Banff National Park" },
                    { 11, "Australia", "Experience the iconic Opera House designed by Jørn Utzon", "/images/Sydney.jpg", "Sydney Opera House" },
                    { 12, "Australia", "Experience the world's biggest coral reef system in Cairns", "/images/Cairns.jpg", "Great Barrier Reef" },
                    { 13, "Japan", "Experience one of Japan's most famous shinto-shrines", "/images/Kyoto.jpg", "Fushimi Inari-taisha" },
                    { 14, "Japan", "Experience Japan's biggest mountain", "/images/Fujinomiya.jpg", "Mount Fuji" },
                    { 15, "Brazil", "Experience Cristo Redentor, one of the world's most iconic statues", "/images/RioDeJaneiro.jpg", "Cristo Redentor" },
                    { 16, "Brazil", "Experience the Iguazu-waterfalls, one of the world's biggest waterfalls", "/images/FozDoIguaco.jpg", "Iguazu-waterfalls" },
                    { 17, "China", "Experience the Great Wall of China in Beijing", "/images/Beijing.jpg", "Great Wall of China" },
                    { 18, "China", "Experience The Terracotta Army which is over 2000 years old", "/images/Xian.jpg", "The Terracotta Army" },
                    { 19, "India", "Experience The Taj Mahal, one of the seven wonders of the world", "/images/Agra.jpg", "The Taj Mahal" },
                    { 20, "India", "Experience The Kerala Backwaters, which is a network of lakes, canals and lagoons", "/images/Alappuzha.jpg", "The Kerala Backwaters" },
                    { 21, "Russia", "Experience the iconic symbol of Russia, Saint Basil's Cathedral", "/images/Moscow.jpg", "Saint Basil's Cathedral" },
                    { 22, "Russia", "Experience one of the largest and oldest museums in the world", "/images/SaintPeterburg.jpg", "Hotel Saint Petersburg" },
                    { 23, "South Africa", "Experience an iconic flat-topped mountain overlooking Cape Town", "/images/CapeTown.jpg", "Table Mountain" },
                    { 24, "South Africa", "Experience one of Africa's largest game reserves", "/images/Nelspruit.jpg", "Kruger National Park" },
                    { 25, "Egypt", "Experience The Great Pyramids of Giza", "/images/Giza.jpg", "The Pyramids of Giza" },
                    { 26, "Egypt", "Experience The Valley of The Kings where many Pharaohs of the New Kingdom were buried", "/images/Luxor.jpg", "The Valley of The Kings" },
                    { 27, "Argentina", "Experience one of the few advancing glaciers in the world", "/images/ElCalafate.jpg", "Perito Moreno Glacier" },
                    { 28, "Argentina", "Experience one of the World's most stunning natural wonders", "/images/IguazuFalls.jpg", "Iguazu Falls" },
                    { 29, "Mexico", "Experience the UNESCO World Heritage", "/images/Tinum.jpg", "Chicken Itza" },
                    { 30, "Mexico", "Experience a natural sinkhole renowned for its stunning beauty", "/images/Tinum1.jpg", "Cenote Ik Kil" },
                    { 31, "Turkey", "Experience a Hot Air Balloon Ride in Cappadocia", "/images/Goreme.jpg", "Hot Air Balloon Ride" },
                    { 32, "Turkey", "Experience The Hagia Sophia, served as a mosque and museum over the centuries", "/images/Istanbul.jpg", "The Hagia Sophia" },
                    { 33, "Greece", "Experience the world famous archaeological site Acropolis", "/images/Athen.jpg", "Acropolis" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Country", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Denmark", "A modern hotel in the heart of Copenhagen.", "/images/CPH.jpg", "Hotel Copenhagen", 250 },
                    { 2, "Denmark", "A cozy hotel in Aarhus.", "/images/Aarhus.jpg", "Hotel Aarhus", 120 },
                    { 3, "Germany", "An upscale hotel near Brandenburg Gate.", "/images/hotelb.jpg", "Hotel Berlin", 285 },
                    { 4, "Germany", "A charming hotel in Munich.", "/images/hotelmun.jpg", "Hotel Munich", 150 },
                    { 5, "France", "A romantic hotel with views of the Eiffel Tower.", "/images/hotelp.jpg", "Hotel Paris", 287 },
                    { 6, "France", "A beautiful hotel in Lyon.", "/images/hotellyon.jpg", "Hotel Lyon", 137 },
                    { 7, "Canada", "A charming hotel in the city center.", "/images/hoteltoronto.jpg", "Hotel Toronto", 184 },
                    { 8, "Canada", "A stylish hotel in Milan.", "/images/hotelv.jpg", "Hotel Vancouver", 193 },
                    { 9, "Australia", "A vibrant hotel near the beach.", "/images/hotelss.jpg", "Hotel Sydney", 152 },
                    { 10, "Australia", "A luxurious hotel in the capital.", "/images/hotelc.jpg", "Hotel Canberra", 163 },
                    { 11, "Japan", "A modern hotel in Manchester.", "/images/hotelttt.jpg", "Hotel Tokyo", 243 },
                    { 12, "Japan", "A stylish hotel in the city.", "/images/hotelosa.jpg", "Hotel Osaka", 175 },
                    { 13, "Brazil", "A stylish hotel in the city.", "/images/hotelbra.jpg", "Hotel Brasilia", 190 },
                    { 14, "Brazil", "A stylish hotel in the city.", "/images/hotelpao.jpg", "Hotel Sao Paulo", 126 },
                    { 15, "China", "A stylish hotel in the city.", "/images/hotelbei.jpg", "Hotel Beijing", 172 },
                    { 16, "China", "A stylish hotel in the city.", "/images/hotelshang.jpg", "Hotel Shanghai", 229 },
                    { 17, "India", "A stylish hotel in the city.", "/images/hotelmom.jpg", "Hotel Mumbai", 268 },
                    { 18, "India", "A stylish hotel in the city.", "/images/hotelcurry.jpg", "Hotel Surat", 222 },
                    { 19, "Russia", "A stylish hotel in the city.", "/images/hotelputin.jpg", "Hotel Moscow", 103 },
                    { 20, "Russia", "A stylish hotel in the city.", "/images/hotelsaint.jpg", "Hotel Saint Petersburg", 200 },
                    { 21, "South Africa", "A stylish hotel in the city.", "/images/hoteltown.jpg", "Hotel Cape Town", 130 },
                    { 22, "South Africa", "A stylish hotel in the city.", "/images/hotelburg.jpg", "Hotel Johannesburg", 190 },
                    { 23, "Egypt", "A stylish hotel in the city.", "/images/hotelsalah.jpg", "Hotel Cairo", 110 },
                    { 24, "Egypt", "A stylish hotel in the city.", "/images/hotelgiza.jpg", "Hotel Giza", 145 },
                    { 25, "Argentina", "A stylish hotel in the city.", "/images/hotelaries.jpg", "Hotel Buenos Aires", 120 },
                    { 26, "Argentina", "A stylish hotel in the city.", "/images/hotelcor.jpg", "Hotel Cordoba", 125 },
                    { 27, "Mexico", "A stylish hotel in the city.", "/images/hotelmexico.jpg", "Hotel Mexico City", 225 },
                    { 28, "Mexico", "A stylish hotel in the city.", "/images/hotelg.jpg", "Hotel Guadalajara", 175 },
                    { 29, "Turkey", "A stylish hotel in the city.", "/images/hotelis.jpg", "Hotel Istanbul", 250 },
                    { 30, "Turkey", "A stylish hotel in the city.", "/images/hotelan.jpg", "Hotel Antalya", 300 },
                    { 31, "Greece", "A stylish hotel in the city.", "/images/hotelat.jpg", "Hotel Athens", 150 },
                    { 32, "Greece", "A stylish hotel in the city.", "/images/hotelrho.jpg", "Hotel Rhodes", 200 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Domain", "Email", "FullName", "Password", "Role", "SecurityLevel", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotelbooking.com", "Enesyil38@hotmail.com", "Enes Yildiz", "1234", "Admin", 2, "Admin" },
                    { 2, new DateTime(1999, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotelbooking.com", "august.hunnerup@gmail.com", "August Hunnerup Østergaard", "1234", "Customer", 1, "August" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
