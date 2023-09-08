using Microsoft.EntityFrameworkCore;
using ParkView.Data;

namespace ParkView.Models.Domain
{
	public class HotelRepo : IHotel
	{
        private readonly ParkViewDbContext _context;



        public HotelRepo(ParkViewDbContext context)
        {
            _context = context;
        }



        public void BookRoom(int hotelId, string userId, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, string roomType)
        {
            var hotel = _context.Hotels.FirstOrDefault(hotel => hotel.Id == hotelId);
            if (hotel == null)
            {
                throw new InvalidOperationException("Hotel not found");
            }



            if (!IsRoomTypeAvailable(hotelId, roomType, checkInDate, checkOutDate))
            {
                throw new InvalidOperationException("No Rooms of the specific type available for this date");
            }



            decimal roomPrice = GetRoomPrice(hotelId, roomType);
            int numberOfNights = (int)(checkOutDate - checkInDate).TotalDays;
            int totalPrice = (int)roomPrice * numberOfNights;



            var booking = new Booking
            {
                HotelId = hotelId,
                UserId = userId,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                NumberOfGuests = numberOfGuests,
                RoomType = roomType,
                TotalPrice = totalPrice,
                BookingDate = DateTime.Now
            };



            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }




        public IEnumerable<Hotel> GetAllHotels()
        {
            return _context.Hotels.ToList();
        }



        public int GetRoomPrice(int hotelId, string roomType)
        {
            var hotel = _context.Hotels.SingleOrDefault(h => h.Id == hotelId);



            if (hotel == null)
            {
                throw new InvalidOperationException("This kind of hotel is not present");
            }



            int roomPrice = roomType switch
            {
                "President" => hotel.NumPresedentialRooms,
                "Deluxe" => hotel.NumDeluxeRooms,
                "SuperDeluxe" => hotel.NumSuperDeluxeRooms,
                "Executive" => hotel.NumExecutiveRooms
            };



            return roomPrice;
        }





        public List<string> GetDistinctRoomTypesForHotel(int id)
        {
            var hotelWithDistinctRoomTypes = _context.Hotels
                .Where(h => h.Id == id)
                .Include(h => h.Rooms)
                .Select(h => new
                {
                    Hotel = h,
                    DistinctRoomTypes = h.Rooms
                        .Select(r => r.RoomType)
                        .Distinct()
                })
                .FirstOrDefault();



            if (hotelWithDistinctRoomTypes != null)
            {
                var distinctRoomTypes = hotelWithDistinctRoomTypes.DistinctRoomTypes.ToList();
                return distinctRoomTypes;
            }



            return new List<string>();
        }



        public Hotel GetHotelById(int id)

        {
            return _context.Hotels.Include(r => r.Rooms).FirstOrDefault(h => h.Id == id);
        }



        public int GetTotalRoomsOfType(int hotelId, string roomType)
        {
            throw new NotImplementedException();
        }



        public bool IsRoomTypeAvailable(int hotelId, string roomType, DateTime checkInDate, DateTime checkOutDate)
        {
            var existingBookings = _context.Bookings.Where(b => b.RoomType == roomType && b.HotelId == hotelId).ToList();



            foreach (var booking in existingBookings)
            {
                if (!(checkOutDate <= booking.CheckInDate || checkInDate >= booking.CheckOutDate))
                {
                    return false;
                }
            }
            return true;
        }



        public IEnumerable<Hotel> SearchHotels(string query)
        {
            // Customize this query to match your database structure and search criteria
            return _context.Hotels
                .Where(h => h.Name.Contains(query) || h.Place.Contains(query))
                .ToList();
        }
    }
}
