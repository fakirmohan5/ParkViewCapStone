namespace ParkView.Models.Domain
{
    public class Room
    {

       
        public int RoomId { get; set; }
        public int HotelId { get; set; }



        public Hotel Hotel { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }

        public string imageUrl { get; set;}



        
    }
}
