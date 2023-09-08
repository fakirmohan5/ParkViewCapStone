using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms" },
                values: new object[] { 4, 2, 2, 12, 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms" },
                values: new object[] { 4, 2, 2, 12, 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms" },
                values: new object[] { 4, 2, 2, 12, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms" },
                values: new object[] { 20, 15, 10, 60, 15 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms" },
                values: new object[] { 20, 15, 10, 60, 15 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumDeluxeRooms", "NumExecutiveRooms", "NumPresedentialRooms", "NumRooms", "NumSuperDeluxeRooms" },
                values: new object[] { 20, 15, 10, 60, 15 });
        }
    }
}
