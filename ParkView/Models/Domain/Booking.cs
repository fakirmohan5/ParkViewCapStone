namespace ParkView.Models.Domain
{
    public class Booking
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string UserId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public string RoomType { get; set; }
        public int TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }

        public Hotel Hotel { get; set; }


    }
}