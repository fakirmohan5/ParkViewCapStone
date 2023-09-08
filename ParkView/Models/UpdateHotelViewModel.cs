using ParkView.Models.Domain;

namespace ParkView.Models
{
    public class UpdateHotelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Place { get; set; }

        public int NumRooms { get; set; }

        public List<Room> Rooms { get; set; }


        public List<Booking> Bookings { get; set; }

        public int NumPresedentialRooms { get; set; }

        public int NumExecutiveRooms { get; set; }

        public int NumSuperDeluxeRooms { get; set; }


        public int NumDeluxeRooms { get; set; }

        public string imageUrl { get; set; }
    }
}
