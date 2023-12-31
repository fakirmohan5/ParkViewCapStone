﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkView.Data;

#nullable disable

namespace ParkView.Migrations
{
    [DbContext(typeof(ParkViewDbContext))]
    [Migration("20230907065645_CombinedcodeMigration")]
    partial class CombinedcodeMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ParkView.Models.Domain.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ParkView.Models.Domain.BookRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Aadhar")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hotel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookRooms");
                });

            modelBuilder.Entity("ParkView.Models.Domain.CabBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("dateOfBooking")
                        .HasColumnType("datetime2");

                    b.Property<string>("place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CabBooks");
                });

            modelBuilder.Entity("ParkView.Models.Domain.CabBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DropoffLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CabBooking");
                });

            modelBuilder.Entity("ParkView.Models.Domain.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumDeluxeRooms")
                        .HasColumnType("int");

                    b.Property<int>("NumExecutiveRooms")
                        .HasColumnType("int");

                    b.Property<int>("NumPresedentialRooms")
                        .HasColumnType("int");

                    b.Property<int>("NumRooms")
                        .HasColumnType("int");

                    b.Property<int>("NumSuperDeluxeRooms")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Grand ParkView",
                            NumDeluxeRooms = 4,
                            NumExecutiveRooms = 2,
                            NumPresedentialRooms = 2,
                            NumRooms = 12,
                            NumSuperDeluxeRooms = 4,
                            Place = "Goa",
                            imageUrl = "/Images/HotelView/1.webp"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Palace ParkView",
                            NumDeluxeRooms = 4,
                            NumExecutiveRooms = 2,
                            NumPresedentialRooms = 2,
                            NumRooms = 12,
                            NumSuperDeluxeRooms = 4,
                            Place = "Munnar",
                            imageUrl = "/Images/HotelView/2.webp"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Regency ParkView",
                            NumDeluxeRooms = 4,
                            NumExecutiveRooms = 2,
                            NumPresedentialRooms = 2,
                            NumRooms = 12,
                            NumSuperDeluxeRooms = 4,
                            Place = "Manali",
                            imageUrl = "/Images/HotelView/3.webp"
                        });
                });

            modelBuilder.Entity("ParkView.Models.Domain.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ParkView.Models.Domain.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.HasIndex("HotelId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            HotelId = 1,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 2,
                            HotelId = 1,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 3,
                            HotelId = 1,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 4,
                            HotelId = 1,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 5,
                            HotelId = 1,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 6,
                            HotelId = 1,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 7,
                            HotelId = 1,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 8,
                            HotelId = 1,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 9,
                            HotelId = 1,
                            Price = 20000m,
                            RoomType = "Executive",
                            imageUrl = "/Images/RoomView/executive.webp"
                        },
                        new
                        {
                            RoomId = 10,
                            HotelId = 1,
                            Price = 20000m,
                            RoomType = "Executive",
                            imageUrl = "/Images/RoomView/executive.webp"
                        },
                        new
                        {
                            RoomId = 11,
                            HotelId = 1,
                            Price = 30000m,
                            RoomType = "Presidential",
                            imageUrl = "/Images/RoomView/presidential.webp"
                        },
                        new
                        {
                            RoomId = 12,
                            HotelId = 1,
                            Price = 30000m,
                            RoomType = "Presidential",
                            imageUrl = "/Images/RoomView/presidential.webp"
                        },
                        new
                        {
                            RoomId = 13,
                            HotelId = 2,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 14,
                            HotelId = 2,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 15,
                            HotelId = 2,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 16,
                            HotelId = 2,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 17,
                            HotelId = 2,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 18,
                            HotelId = 2,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 19,
                            HotelId = 2,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 20,
                            HotelId = 2,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 21,
                            HotelId = 2,
                            Price = 20000m,
                            RoomType = "Executive",
                            imageUrl = "/Images/RoomView/executive.webp"
                        },
                        new
                        {
                            RoomId = 22,
                            HotelId = 2,
                            Price = 20000m,
                            RoomType = "Executive",
                            imageUrl = "/Images/RoomView/executive.webp"
                        },
                        new
                        {
                            RoomId = 23,
                            HotelId = 2,
                            Price = 30000m,
                            RoomType = "Presidential",
                            imageUrl = "/Images/RoomView/presidential.webp"
                        },
                        new
                        {
                            RoomId = 24,
                            HotelId = 2,
                            Price = 30000m,
                            RoomType = "Presidential",
                            imageUrl = "/Images/RoomView/presidential.webp"
                        },
                        new
                        {
                            RoomId = 25,
                            HotelId = 3,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 26,
                            HotelId = 3,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 27,
                            HotelId = 3,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 28,
                            HotelId = 3,
                            Price = 10000m,
                            RoomType = "Deluxe",
                            imageUrl = "/Images/RoomView/deluxe.webp"
                        },
                        new
                        {
                            RoomId = 29,
                            HotelId = 3,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 30,
                            HotelId = 3,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 31,
                            HotelId = 3,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 32,
                            HotelId = 3,
                            Price = 15000m,
                            RoomType = "SuperDeluxe",
                            imageUrl = "/Images/RoomView/sup-deluxe.webp"
                        },
                        new
                        {
                            RoomId = 33,
                            HotelId = 3,
                            Price = 20000m,
                            RoomType = "Executive",
                            imageUrl = "/Images/RoomView/executive.webp"
                        },
                        new
                        {
                            RoomId = 34,
                            HotelId = 3,
                            Price = 20000m,
                            RoomType = "Executive",
                            imageUrl = "/Images/RoomView/executive.webp"
                        },
                        new
                        {
                            RoomId = 35,
                            HotelId = 3,
                            Price = 30000m,
                            RoomType = "Presidential",
                            imageUrl = "/Images/RoomView/presidential.webp"
                        },
                        new
                        {
                            RoomId = 36,
                            HotelId = 3,
                            Price = 30000m,
                            RoomType = "Presidential",
                            imageUrl = "/Images/RoomView/presidential.webp"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParkView.Models.Domain.Booking", b =>
                {
                    b.HasOne("ParkView.Models.Domain.Hotel", "Hotel")
                        .WithMany("Bookings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("ParkView.Models.Domain.Room", b =>
                {
                    b.HasOne("ParkView.Models.Domain.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("ParkView.Models.Domain.Hotel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
