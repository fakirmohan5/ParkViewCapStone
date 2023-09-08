using Microsoft.EntityFrameworkCore;
using ParkView.Data;

namespace ParkView.Models.Domain
{
    public class BookingRepo : IBooking
    {
        private readonly ParkViewDbContext _context;



        public BookingRepo(ParkViewDbContext context)
        {
            _context = context;
        }



        public IEnumerable<Booking> GetAllBookings
        {
            get { return _context.Bookings.Include(s => s.Hotel); }
        }



        public Booking GetBookingById(int id)
        {
            return GetAllBookings.FirstOrDefault(s => s.HotelId == id);
        }
    }
}
