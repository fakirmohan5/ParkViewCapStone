using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
	public class OrderDetailsViewModel
	{
		public string CustomerName { get; set; }
		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public double TotalAmount { get; set; }

		[NotMapped]
		public string TransactionId { get; set; }
		[NotMapped]
		public string OrderId { get; set; }

	}
}
