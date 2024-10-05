﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WonderPlane.Server.Models;

#nullable disable

namespace WonderPlane.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241005054335_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("WonderPlane")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WonderPlane.Server.Models.BoardingPass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CheckInStatus")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("CheckInTime")
                        .HasColumnType("time");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BoardingPass", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegisteredUserId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("Card", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArriveDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("ArriveTime")
                        .HasColumnType("time");

                    b.Property<decimal>("BagPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("DepartureTime")
                        .HasColumnType("time");

                    b.Property<int>("Destination")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightStatus")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInternational")
                        .HasColumnType("bit");

                    b.Property<int>("Origin")
                        .HasColumnType("int");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Flight", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.FlightRecommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FlightId")
                        .HasColumnType("int");

                    b.Property<int?>("RecommendationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("RecommendationId");

                    b.ToTable("FlightRecommendation", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Forums", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ForumId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("News", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FlightId")
                        .HasColumnType("int");

                    b.Property<int>("PromotionStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FlightId")
                        .IsUnique()
                        .HasFilter("[FlightId] IS NOT NULL");

                    b.ToTable("Promotion", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PurchaseStatus")
                        .HasColumnType("int");

                    b.Property<int?>("RegisteredUserId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("Purchase", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Recommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecommendationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegisteredUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("Recommendation", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("PaymentLimitDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegisteredUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("Reservation", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Search", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("RegisteredUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SearchDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("Search", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FlightId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SeatStatus")
                        .HasColumnType("int");

                    b.Property<int>("SeatType")
                        .HasColumnType("int");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Seat", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BoardingPassId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int?>("SeatId")
                        .HasColumnType("int");

                    b.Property<int?>("TravelerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoardingPassId")
                        .IsUnique()
                        .HasFilter("[BoardingPassId] IS NOT NULL");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("SeatId")
                        .IsUnique()
                        .HasFilter("[SeatId] IS NOT NULL");

                    b.HasIndex("TravelerId");

                    b.ToTable("Ticket", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Traveler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("RegisteredUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Traveler", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Country")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSuscribedToNews")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool?>("ReciveNotifications")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TravelerId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("TravelerId")
                        .IsUnique()
                        .HasFilter("[TravelerId] IS NOT NULL");

                    b.ToTable("Users", "WonderPlane");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Card", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.User", "RegisteredUser")
                        .WithMany("Cards")
                        .HasForeignKey("RegisteredUserId");

                    b.Navigation("RegisteredUser");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.FlightRecommendation", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.Flight", "Flight")
                        .WithMany("FlightRecommendations")
                        .HasForeignKey("FlightId");

                    b.HasOne("WonderPlane.Server.Models.Recommendation", "Recommendation")
                        .WithMany("FlightRecommendations")
                        .HasForeignKey("RecommendationId");

                    b.Navigation("Flight");

                    b.Navigation("Recommendation");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Forum", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.User", "User")
                        .WithMany("Forums")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("User");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Message", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.Forum", "Forum")
                        .WithMany("Messages")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("WonderPlane.Server.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Forum");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.News", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.Flight", "Flight")
                        .WithMany("News")
                        .HasForeignKey("FlightId");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Promotion", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.Flight", "Flight")
                        .WithOne("Promotion")
                        .HasForeignKey("WonderPlane.Server.Models.Promotion", "FlightId");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Purchase", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.User", "RegisteredUser")
                        .WithMany("Purchases")
                        .HasForeignKey("RegisteredUserId");

                    b.Navigation("RegisteredUser");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Recommendation", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.User", "RegisteredUser")
                        .WithMany()
                        .HasForeignKey("RegisteredUserId");

                    b.Navigation("RegisteredUser");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Reservation", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.User", "RegisteredUser")
                        .WithMany("Reservations")
                        .HasForeignKey("RegisteredUserId");

                    b.Navigation("RegisteredUser");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Search", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.User", "RegisteredUser")
                        .WithMany("Searches")
                        .HasForeignKey("RegisteredUserId");

                    b.Navigation("RegisteredUser");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Seat", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.Flight", "Flight")
                        .WithMany("Seats")
                        .HasForeignKey("FlightId");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Ticket", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.BoardingPass", "BoardingPass")
                        .WithOne("Ticket")
                        .HasForeignKey("WonderPlane.Server.Models.Ticket", "BoardingPassId");

                    b.HasOne("WonderPlane.Server.Models.Purchase", "Purchase")
                        .WithMany("Tickets")
                        .HasForeignKey("PurchaseId");

                    b.HasOne("WonderPlane.Server.Models.Reservation", "Reservation")
                        .WithMany("Tickets")
                        .HasForeignKey("ReservationId");

                    b.HasOne("WonderPlane.Server.Models.Seat", "Seat")
                        .WithOne("Ticket")
                        .HasForeignKey("WonderPlane.Server.Models.Ticket", "SeatId");

                    b.HasOne("WonderPlane.Server.Models.Traveler", "Traveler")
                        .WithMany("Tickets")
                        .HasForeignKey("TravelerId");

                    b.Navigation("BoardingPass");

                    b.Navigation("Purchase");

                    b.Navigation("Reservation");

                    b.Navigation("Seat");

                    b.Navigation("Traveler");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.User", b =>
                {
                    b.HasOne("WonderPlane.Server.Models.Traveler", "Traveler")
                        .WithOne("RegisteredUser")
                        .HasForeignKey("WonderPlane.Server.Models.User", "TravelerId");

                    b.Navigation("Traveler");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.BoardingPass", b =>
                {
                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Flight", b =>
                {
                    b.Navigation("FlightRecommendations");

                    b.Navigation("News");

                    b.Navigation("Promotion");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Forum", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Purchase", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Recommendation", b =>
                {
                    b.Navigation("FlightRecommendations");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Reservation", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Seat", b =>
                {
                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.Traveler", b =>
                {
                    b.Navigation("RegisteredUser");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("WonderPlane.Server.Models.User", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("Forums");

                    b.Navigation("Messages");

                    b.Navigation("Purchases");

                    b.Navigation("Reservations");

                    b.Navigation("Searches");
                });
#pragma warning restore 612, 618
        }
    }
}
