using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models.Domain
{
	public class OrderEntity
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "Please Provide  Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = " Name Should be min 5 and max 20 length")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please Provide  Email")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = " Email Should be min 5 and max 20 length")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Provide  PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Total Amount has to be More Than 0")]

        public double TotalAmount { get; set; }

		public string TransactionId { get; set; }
		public string OrderId { get; set; }
	}
}
