namespace ParkView.Models.Domain
{
	public class CabBook
	{
		public Guid Id { get; set; }

		public DateTime dateOfBooking { get; set; }
		public string place { get; set; }
	}
}
