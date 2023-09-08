namespace ParkView.Models.Domain
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public string Place { get; set; }

        public int NumRooms { get; set; }

        public List<Room> Rooms { get; set; }


        public List<Booking> Bookings { get; set; }

        public int NumPresedentialRooms { get; set; } = 1500;

        public int NumExecutiveRooms { get; set; } = 2000;

        public int NumSuperDeluxeRooms { get; set; } = 3000;


        public int NumDeluxeRooms { get; set; } = 2500;

        public string imageUrl { get; set; }







    }
}
