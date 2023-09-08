using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadhar = table.Column<int>(type: "int", nullable: false),
                    Hotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CabBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateOfBooking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumRooms = table.Column<int>(type: "int", nullable: false),
                    NumPresedentialRooms = table.Column<int>(type: "int", nullable: false),
                    NumExecutiveRooms = table.Column<int>(type: "int", nullable: false),
                    NumSuperDeluxeRooms = table.Column<int>(type: "int", nullable: false),
                    NumDeluxeRooms = table.Column<int>(type: "int", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Name", "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms", "Place", "imageUrl" },
                values: new object[] { 1, "Grand ParkView", 20, 15, 10, 60, 15, "Goa", "/Images/HotelView/1.webp" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Name", "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms", "Place", "imageUrl" },
                values: new object[] { 2, "Palace ParkView", 20, 15, 10, 60, 15, "Munnar", "/Images/HotelView/2.webp" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Name", "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms", "Place", "imageUrl" },
                values: new object[] { 3, "Regency ParkView", 20, 15, 10, 60, 15, "Manali", "/Images/HotelView/3.webp" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "HotelId", "Price", "RoomType", "imageUrl" },
                values: new object[,]
                {
                    { 1, 1, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 2, 1, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 3, 1, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 4, 1, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 5, 1, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 6, 1, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 7, 1, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 8, 1, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 9, 1, 20000m, "Executive", "/Images/RoomView/executive.webp" },
                    { 10, 1, 20000m, "Executive", "/Images/RoomView/executive.webp" },
                    { 11, 1, 30000m, "Presidential", "/Images/RoomView/presidential.webp" },
                    { 12, 1, 30000m, "Presidential", "/Images/RoomView/presidential.webp" },
                    { 13, 2, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 14, 2, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 15, 2, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 16, 2, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 17, 2, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 18, 2, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 19, 2, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 20, 2, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 21, 2, 20000m, "Executive", "/Images/RoomView/executive.webp" },
                    { 22, 2, 20000m, "Executive", "/Images/RoomView/executive.webp" },
                    { 23, 2, 30000m, "Presidential", "/Images/RoomView/presidential.webp" },
                    { 24, 2, 30000m, "Presidential", "/Images/RoomView/presidential.webp" },
                    { 25, 3, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 26, 3, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 27, 3, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 28, 3, 10000m, "Deluxe", "/Images/RoomView/deluxe.webp" },
                    { 29, 3, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 30, 3, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 31, 3, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 32, 3, 15000m, "SuperDeluxe", "/Images/RoomView/sup-deluxe.webp" },
                    { 33, 3, 20000m, "Executive", "/Images/RoomView/executive.webp" },
                    { 34, 3, 20000m, "Executive", "/Images/RoomView/executive.webp" },
                    { 35, 3, 30000m, "Presidential", "/Images/RoomView/presidential.webp" },
                    { 36, 3, 30000m, "Presidential", "/Images/RoomView/presidential.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_HotelId",
                table: "Booking",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelId",
                table: "Room",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "BookRooms");

            migrationBuilder.DropTable(
                name: "CabBooks");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
