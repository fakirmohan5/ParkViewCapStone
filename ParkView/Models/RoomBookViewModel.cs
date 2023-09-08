using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ParkView.Models
{
	public class RoomBookViewModel
	{


        [Required(ErrorMessage = "Please Provide  Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = " Name Should be min 5 and max 20 length")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Please Provide  Aadhar")]
        public int Aadhar { get; set; }





        [Required(ErrorMessage = "Please Provide  Name of Hotel")]
        public string Hotel { get; set; }



        [Required(ErrorMessage = "Please Provide Room Type")]
        public string RoomType { get; set; }





        [Required(ErrorMessage = "Please Provide  Check-in date")]
        public DateTime CheckInDate { get; set; }





        [Required(ErrorMessage = "Please Provide Checkout date")]
        public DateTime CheckOutDate { get; set; }






    }
}






