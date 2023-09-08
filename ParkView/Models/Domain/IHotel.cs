namespace ParkView.Models.Domain
{
	public interface IHotel
	{

        IEnumerable<Hotel> GetAllHotels();
        public List<string> GetDistinctRoomTypesForHotel(int id);
        Hotel GetHotelById(int id);





        IEnumerable<Hotel> SearchHotels(string query);



        bool IsRoomTypeAvailable(int hotelId, string roomType, DateTime checkInDate, DateTime checkOutDate);



        public void BookRoom(int hotelId, string userId, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, string roomType);



        public int GetRoomPrice(int hotelId, string roomType);



        int GetTotalRoomsOfType(int hotelId, string roomType);



    }
}

