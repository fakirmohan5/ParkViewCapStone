using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ParkView.Models
{
    public class AddHotelViewModel
    {
		[Required( ErrorMessage = "Please Provide  Name")]
		[StringLength(20, MinimumLength = 5, ErrorMessage = " Name Should be min 5 and max 20 length")]
		public string Name { get; set; }

		[Required( ErrorMessage = "Please Provide  Place")]
		[StringLength(20, MinimumLength = 5, ErrorMessage = " Name of place Should be min 5 and max 20 length")]
		public string Place { get; set; }


		[Required( ErrorMessage = "Please Provide  Number of Total rooms")]
		public int NumRooms { get; set; }

		[Required( ErrorMessage = "Please Provide  Number of presidential rooms")]
		public int NumPresedentialRooms { get; set; }


		[Required( ErrorMessage = "Please Provide  Number of executive rooms")]
		public int NumExecutiveRooms { get; set; }


		[Required( ErrorMessage = "Please Provide  Number of super deluxe rooms")]
		public int NumSuperDeluxeRooms { get; set; }


		[Required( ErrorMessage = "Please Provide  Number of deluxe rooms")]
		public int NumDeluxeRooms { get; set; }

        [Required(ErrorMessage = "Please Provide  Image Title")]

        public string ImageTitle { get; set; }

		public string? ImageUrl
		{
			get
			{
				return "/Images/HotelView/" + $"{ImageTitle}"+ ".webp";
			}
		}


        




    }
}
