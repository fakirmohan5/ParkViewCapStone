namespace ParkView.Models.Domain
{
    public class CabBooking
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public DateTime BookingTime { get; set; }
        public string Status { get; set; }
    }
}
