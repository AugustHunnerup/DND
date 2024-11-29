﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20241129144100_RenameHotelColumn")]
    partial class RenameHotelColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("TEXT");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Denmark",
                            Description = "Experience Legoland in Billund",
                            ImageUrl = "/images/legolegolego.jpeg",
                            Name = "Legoland"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Denmark",
                            Description = "Experience Tivoli in Copenhagen",
                            ImageUrl = "/images/kbhtivoli.jpg",
                            Name = "Tivoli"
                        },
                        new
                        {
                            Id = 3,
                            Country = "Denmark",
                            Description = "Experience Kongelig teater in Copenhagen",
                            ImageUrl = "/images/kongeligeteaterrrr.jpg",
                            Name = "Kongelige teater"
                        },
                        new
                        {
                            Id = 4,
                            Country = "Denmark",
                            Description = "Experience Jellingestenen in Sydjylland",
                            ImageUrl = "/images/jellingsteeen.jpg",
                            Name = "Jellingestenen"
                        },
                        new
                        {
                            Id = 5,
                            Country = "Germany",
                            Description = "Experience Europa-Park and its exciting roller coasters",
                            ImageUrl = "/images/Rust1.jpg",
                            Name = "Europa-Park"
                        },
                        new
                        {
                            Id = 6,
                            Country = "Germany",
                            Description = "Experience a beautiful and peaceful park in North Germany",
                            ImageUrl = "/images/Goslar.jpg",
                            Name = "Nationalpark Harz"
                        },
                        new
                        {
                            Id = 7,
                            Country = "France",
                            Description = "Experience the amazing view of the Eiffel Tower.",
                            ImageUrl = "/images/Paris.jpg",
                            Name = "Eiffel Tower"
                        },
                        new
                        {
                            Id = 8,
                            Country = "France",
                            Description = "Experience a tasteful wine tour in Bordeaux",
                            ImageUrl = "/images/Bordeaux.jpg",
                            Name = "Wine Tour"
                        },
                        new
                        {
                            Id = 9,
                            Country = "Canada",
                            Description = "Experience the massive waterfall Niagara Falls in Ontario",
                            ImageUrl = "/images/Ontario.jpg",
                            Name = "Niagara Falls"
                        },
                        new
                        {
                            Id = 10,
                            Country = "Canada",
                            Description = "Experience Canada's oldest national park Banff",
                            ImageUrl = "/images/Alberta.jpg",
                            Name = "Banff National Park"
                        },
                        new
                        {
                            Id = 11,
                            Country = "Australia",
                            Description = "Experience the iconic Opera House designed by Jørn Utzon",
                            ImageUrl = "/images/Sydney.jpg",
                            Name = "Sydney Opera House"
                        },
                        new
                        {
                            Id = 12,
                            Country = "Australia",
                            Description = "Experience the world's biggest coral reef system in Cairns",
                            ImageUrl = "/images/Cairns.jpg",
                            Name = "Great Barrier Reef"
                        },
                        new
                        {
                            Id = 13,
                            Country = "Japan",
                            Description = "Experience one of Japan's most famous shinto-shrines",
                            ImageUrl = "/images/Kyoto.jpg",
                            Name = "Fushimi Inari-taisha"
                        },
                        new
                        {
                            Id = 14,
                            Country = "Japan",
                            Description = "Experience Japan's biggest mountain",
                            ImageUrl = "/images/Fujinomiya.jpg",
                            Name = "Mount Fuji"
                        },
                        new
                        {
                            Id = 15,
                            Country = "Brazil",
                            Description = "Experience Cristo Redentor, one of the world's most iconic statues",
                            ImageUrl = "/images/RioDeJaneiro.jpg",
                            Name = "Cristo Redentor"
                        },
                        new
                        {
                            Id = 16,
                            Country = "Brazil",
                            Description = "Experience the Iguazu-waterfalls, one of the world's biggest waterfalls",
                            ImageUrl = "/images/FozDoIguaco.jpg",
                            Name = "Iguazu-waterfalls"
                        },
                        new
                        {
                            Id = 17,
                            Country = "China",
                            Description = "Experience the Great Wall of China in Beijing",
                            ImageUrl = "/images/Beijing.jpg",
                            Name = "Great Wall of China"
                        },
                        new
                        {
                            Id = 18,
                            Country = "China",
                            Description = "Experience The Terracotta Army which is over 2000 years old",
                            ImageUrl = "/images/Xian.jpg",
                            Name = "The Terracotta Army"
                        },
                        new
                        {
                            Id = 19,
                            Country = "India",
                            Description = "Experience The Taj Mahal, one of the seven wonders of the world",
                            ImageUrl = "/images/Agra.jpg",
                            Name = "The Taj Mahal"
                        },
                        new
                        {
                            Id = 20,
                            Country = "India",
                            Description = "Experience The Kerala Backwaters, which is a network of lakes, canals and lagoons",
                            ImageUrl = "/images/Alappuzha.jpg",
                            Name = "The Kerala Backwaters"
                        },
                        new
                        {
                            Id = 21,
                            Country = "Russia",
                            Description = "Experience the iconic symbol of Russia, Saint Basil's Cathedral",
                            ImageUrl = "/images/Moscow.jpg",
                            Name = "Saint Basil's Cathedral"
                        },
                        new
                        {
                            Id = 22,
                            Country = "Russia",
                            Description = "Experience one of the largest and oldest museums in the world",
                            ImageUrl = "/images/SaintPeterburg.jpg",
                            Name = "Hotel Saint Petersburg"
                        },
                        new
                        {
                            Id = 23,
                            Country = "South Africa",
                            Description = "Experience an iconic flat-topped mountain overlooking Cape Town",
                            ImageUrl = "/images/CapeTown.jpg",
                            Name = "Table Mountain"
                        },
                        new
                        {
                            Id = 24,
                            Country = "South Africa",
                            Description = "Experience one of Africa's largest game reserves",
                            ImageUrl = "/images/Nelspruit.jpg",
                            Name = "Kruger National Park"
                        },
                        new
                        {
                            Id = 25,
                            Country = "Egypt",
                            Description = "Experience The Great Pyramids of Giza",
                            ImageUrl = "/images/Giza.jpg",
                            Name = "The Pyramids of Giza"
                        },
                        new
                        {
                            Id = 26,
                            Country = "Egypt",
                            Description = "Experience The Valley of The Kings where many Pharaohs of the New Kingdom were buried",
                            ImageUrl = "/images/Luxor.jpg",
                            Name = "The Valley of The Kings"
                        },
                        new
                        {
                            Id = 27,
                            Country = "Argentina",
                            Description = "Experience one of the few advancing glaciers in the world",
                            ImageUrl = "/images/ElCalafate.jpg",
                            Name = "Perito Moreno Glacier"
                        },
                        new
                        {
                            Id = 28,
                            Country = "Argentina",
                            Description = "Experience one of the World's most stunning natural wonders",
                            ImageUrl = "/images/IguazuFalls.jpg",
                            Name = "Iguazu Falls"
                        },
                        new
                        {
                            Id = 29,
                            Country = "Mexico",
                            Description = "Experience the UNESCO World Heritage",
                            ImageUrl = "/images/Tinum.jpg",
                            Name = "Chicken Itza"
                        },
                        new
                        {
                            Id = 30,
                            Country = "Mexico",
                            Description = "Experience a natural sinkhole renowned for its stunning beauty",
                            ImageUrl = "/images/Tinum1.jpg",
                            Name = "Cenote Ik Kil"
                        },
                        new
                        {
                            Id = 31,
                            Country = "Turkey",
                            Description = "Experience a Hot Air Balloon Ride in Cappadocia",
                            ImageUrl = "/images/Goreme.jpg",
                            Name = "Hot Air Balloon Ride"
                        },
                        new
                        {
                            Id = 32,
                            Country = "Turkey",
                            Description = "Experience The Hagia Sophia, served as a mosque and museum over the centuries",
                            ImageUrl = "/images/Istanbul.jpg",
                            Name = "The Hagia Sophia"
                        },
                        new
                        {
                            Id = 33,
                            Country = "Greece",
                            Description = "Experience the world famous archaeological site Acropolis",
                            ImageUrl = "/images/Athen.jpg",
                            Name = "Acropolis"
                        });
                });

            modelBuilder.Entity("Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Denmark",
                            Description = "A modern hotel in the heart of Copenhagen.",
                            ImageUrl = "/images/CPH.jpg",
                            Name = "Hotel Copenhagen"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Denmark",
                            Description = "A cozy hotel in Aarhus.",
                            ImageUrl = "/images/Aarhus.jpg",
                            Name = "Hotel Aarhus"
                        },
                        new
                        {
                            Id = 3,
                            Country = "Germany",
                            Description = "An upscale hotel near Brandenburg Gate.",
                            ImageUrl = "/images/hotelb.jpg",
                            Name = "Hotel Berlin"
                        },
                        new
                        {
                            Id = 4,
                            Country = "Germany",
                            Description = "A charming hotel in Munich.",
                            ImageUrl = "/images/hotelmun.jpg",
                            Name = "Hotel Munich"
                        },
                        new
                        {
                            Id = 5,
                            Country = "France",
                            Description = "A romantic hotel with views of the Eiffel Tower.",
                            ImageUrl = "/images/hotelp.jpg",
                            Name = "Hotel Paris"
                        },
                        new
                        {
                            Id = 6,
                            Country = "France",
                            Description = "A beautiful hotel in Lyon.",
                            ImageUrl = "/images/hotellyon.jpg",
                            Name = "Hotel Lyon"
                        },
                        new
                        {
                            Id = 7,
                            Country = "Canada",
                            Description = "A charming hotel in the city center.",
                            ImageUrl = "/images/hoteltoronto.jpg",
                            Name = "Hotel Toronto"
                        },
                        new
                        {
                            Id = 8,
                            Country = "Canada",
                            Description = "A stylish hotel in Milan.",
                            ImageUrl = "/images/hotelv.jpg",
                            Name = "Hotel Vancouver"
                        },
                        new
                        {
                            Id = 9,
                            Country = "Australia",
                            Description = "A vibrant hotel near the beach.",
                            ImageUrl = "/images/hotelss.jpg",
                            Name = "Hotel Sydney"
                        },
                        new
                        {
                            Id = 10,
                            Country = "Australia",
                            Description = "A luxurious hotel in the capital.",
                            ImageUrl = "/images/hotelc.jpg",
                            Name = "Hotel Canberra"
                        },
                        new
                        {
                            Id = 11,
                            Country = "Japan",
                            Description = "A modern hotel in Manchester.",
                            ImageUrl = "/images/hotelttt.jpg",
                            Name = "Hotel Tokyo"
                        },
                        new
                        {
                            Id = 12,
                            Country = "Japan",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelosa.jpg",
                            Name = "Hotel Osaka"
                        },
                        new
                        {
                            Id = 13,
                            Country = "Brazil",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelbra.jpg",
                            Name = "Hotel Brasilia"
                        },
                        new
                        {
                            Id = 14,
                            Country = "Brazil",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelpao.jpg",
                            Name = "Hotel Sao Paulo"
                        },
                        new
                        {
                            Id = 15,
                            Country = "China",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelbei.jpg",
                            Name = "Hotel Beijing"
                        },
                        new
                        {
                            Id = 16,
                            Country = "China",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelshang.jpg",
                            Name = "Hotel Shanghai"
                        },
                        new
                        {
                            Id = 17,
                            Country = "India",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelmom.jpg",
                            Name = "Hotel Mumbai"
                        },
                        new
                        {
                            Id = 18,
                            Country = "India",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelcurry.jpg",
                            Name = "Hotel Surat"
                        },
                        new
                        {
                            Id = 19,
                            Country = "Russia",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelputin.jpg",
                            Name = "Hotel Moscow"
                        },
                        new
                        {
                            Id = 20,
                            Country = "Russia",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelsaint.jpg",
                            Name = "Hotel Saint Petersburg"
                        },
                        new
                        {
                            Id = 21,
                            Country = "South Africa",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hoteltown.jpg",
                            Name = "Hotel Cape Town"
                        },
                        new
                        {
                            Id = 22,
                            Country = "South Africa",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelburg.jpg",
                            Name = "Hotel Johannesburg"
                        },
                        new
                        {
                            Id = 23,
                            Country = "Egypt",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelsalah.jpg",
                            Name = "Hotel Cairo"
                        },
                        new
                        {
                            Id = 24,
                            Country = "Egypt",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelgiza.jpg",
                            Name = "Hotel Giza"
                        },
                        new
                        {
                            Id = 25,
                            Country = "Argentina",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelaries.jpg",
                            Name = "Hotel Buenos Aires"
                        },
                        new
                        {
                            Id = 26,
                            Country = "Argentina",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelcor.jpg",
                            Name = "Hotel Cordoba"
                        },
                        new
                        {
                            Id = 27,
                            Country = "Mexico",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelmexico.jpg",
                            Name = "Hotel Mexico City"
                        },
                        new
                        {
                            Id = 28,
                            Country = "Mexico",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelg.jpg",
                            Name = "Hotel Guadalajara"
                        },
                        new
                        {
                            Id = 29,
                            Country = "Turkey",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelis.jpg",
                            Name = "Hotel Istanbul"
                        },
                        new
                        {
                            Id = 30,
                            Country = "Turkey",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelan.jpg",
                            Name = "Hotel Antalya"
                        },
                        new
                        {
                            Id = 31,
                            Country = "Greece",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelat.jpg",
                            Name = "Hotel Athens"
                        },
                        new
                        {
                            Id = 32,
                            Country = "Greece",
                            Description = "A stylish hotel in the city.",
                            ImageUrl = "/images/hotelrho.jpg",
                            Name = "Hotel Rhodes"
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(2000, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Domain = "Hotelbooking.com",
                            Email = "Enesyil38@hotmail.com",
                            FullName = "Enes Yildiz",
                            Password = "1234",
                            Role = "Admin",
                            SecurityLevel = 2,
                            Username = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(1999, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Domain = "Hotelbooking.com",
                            Email = "august.hunnerup@gmail.com",
                            FullName = "August Hunnerup Østergaard",
                            Password = "1234",
                            Role = "Customer",
                            SecurityLevel = 1,
                            Username = "August"
                        });
                });

            modelBuilder.Entity("Booking", b =>
                {
                    b.HasOne("User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}