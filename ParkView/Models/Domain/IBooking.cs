namespace ParkView.Models.Domain
{
    public interface IBooking
    {
        public IEnumerable<Booking> GetAllBookings { get; }



        Booking GetBookingById(int id);
    }
}
