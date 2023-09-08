namespace ParkView.Models.Domain
{
	public class BookRoom
	{

		public int Id { get; set; }
		public string Name { get; set; }

		public int Aadhar { get; set; }

		public string Hotel { get; set; }

		public string RoomType { get; set; }

		public DateTime CheckInDate { get; set; }

		public DateTime CheckOutdate { get; set; }

		
	}
}
