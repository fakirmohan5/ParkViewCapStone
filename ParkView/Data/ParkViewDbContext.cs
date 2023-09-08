using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkView.Models.Domain;

namespace ParkView.Data
{
    public class ParkViewDbContext : IdentityDbContext
    {
        public ParkViewDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; } 
        public DbSet<CabBook> CabBooks { get; set; }
        
        public DbSet<CabBooking> CabBooking { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Room> Room { get; set; }  
        
        public DbSet<BookRoom> BookRooms { get; set; }

        public DbSet<OrderEntity> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seeding the DB

            



            // for Rooms Table
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 1, HotelId = 1, RoomType = "Deluxe", Price = 10000,imageUrl = "/Images/RoomView/deluxe.webp" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 2, HotelId = 1, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/1.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 3, HotelId = 1, RoomType = "Deluxe", Price = 10000,imageUrl = "/Images/RoomView/2.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 4, HotelId = 1, RoomType = "Deluxe", Price = 10000,imageUrl = "/Images/RoomView/3.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 5, HotelId = 1, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/4.webp" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 6, HotelId = 1, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/5.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 7, HotelId = 1, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/sup-deluxe.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 8, HotelId = 1, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/4.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 9, HotelId = 1, RoomType = "Executive", Price = 20000, imageUrl = "/Images/RoomView/executive.webp" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 10, HotelId = 1, RoomType = "Executive", Price = 20000, imageUrl = "/Images/RoomView/3.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 11, HotelId = 1, RoomType = "Presidential", Price = 30000, imageUrl = "/Images/RoomView/presidential.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 12, HotelId = 1, RoomType = "Presidential", Price = 30000, imageUrl = "/Images/RoomView/1.jpg" });






            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 13, HotelId = 2, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/deluxe.webp" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 14, HotelId = 2, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/2.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 15, HotelId = 2, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/3.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 16, HotelId = 2, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/4.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 17, HotelId = 2, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/sup-deluxe.webp" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 18, HotelId = 2, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/1.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 19, HotelId = 2, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/17.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 20, HotelId = 2, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/18.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 21, HotelId = 2, RoomType = "Executive", Price = 20000, imageUrl = "/Images/RoomView/executive.webp" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 22, HotelId = 2, RoomType = "Executive", Price = 20000, imageUrl = "/Images/RoomView/11.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 23, HotelId = 2, RoomType = "Presidential", Price = 30000, imageUrl = "/Images/RoomView/presidential.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 24, HotelId = 2, RoomType = "Presidential", Price = 30000, imageUrl = "/Images/RoomView/10.jpg" });



            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 25, HotelId = 3, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/11.jpg" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 26, HotelId = 3, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/13.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 27, HotelId = 3, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/deluxe.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 28, HotelId = 3, RoomType = "Deluxe", Price = 10000, imageUrl = "/Images/RoomView/7.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 29, HotelId = 3, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/8.jpg" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 30, HotelId = 3, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/5.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 31, HotelId = 3, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/6.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 32, HotelId = 3, RoomType = "SuperDeluxe", Price = 15000, imageUrl = "/Images/RoomView/sup-deluxe.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 33, HotelId = 3, RoomType = "Executive", Price = 20000, imageUrl = "/Images/RoomView/2.jpg" });
            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 34, HotelId = 3, RoomType = "Executive", Price = 20000, imageUrl = "/Images/RoomView/executive.webp" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 35, HotelId = 3, RoomType = "Presidential", Price = 30000, imageUrl = "/Images/RoomView/3.jpg" });

            modelBuilder.Entity<Room>().HasData(new Room { RoomId = 36, HotelId = 3, RoomType = "Presidential", Price = 30000, imageUrl = "/Images/RoomView/9.jpg" });




            // for Hotel Table

            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 1, Name = "Grand ParkView", Place = "Goa", NumRooms = 12, NumPresedentialRooms = 2,NumDeluxeRooms = 4,NumExecutiveRooms = 2,NumSuperDeluxeRooms = 4, imageUrl = "/Images/HotelView/1.webp" });

            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 2, Name = "Palace ParkView", Place = "Munnar", NumRooms = 12, NumPresedentialRooms = 2, NumDeluxeRooms = 4, NumExecutiveRooms = 2, NumSuperDeluxeRooms = 4, imageUrl = "/Images/HotelView/2.webp" });

            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 3, Name = "Regency ParkView", Place = "Manali", NumRooms = 12, NumPresedentialRooms = 2, NumDeluxeRooms = 4, NumExecutiveRooms = 2, NumSuperDeluxeRooms = 4, imageUrl = "/Images/HotelView/3.webp" });








        }
    }
}
