using ParkView.Models.Custom_Attributes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ParkView.Models
{
    public class BookingViewModel
    {
        public int RoomId { get; set; } // ID of the selected room
        public int HotelId { get; set; } // ID of the selected hotel



        [Required(ErrorMessage = "Please select a room type.")]
        [Display(Name = "Room Type")]
        public string RoomType { get; set; }



        [Required(ErrorMessage = "Please enter the check-in date.")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-in Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [FutureDate(ErrorMessage = "Check-in date must be a future date")]
        public DateTime CheckInDate { get; set; }



        [Required(ErrorMessage = "Please enter the check-out date.")]
        [DataType(DataType.Date)]
        [Display(Name = "Check-out Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [AdvanceCheckoutDate(  ErrorMessage = "Check-out date must be a future date to check-in date")]

        public DateTime CheckOutDate { get; set; }



        [Required(ErrorMessage = "Please enter the number of guests.")]
        [Display(Name = "Number of Guests")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid number of guests.")]
        public int NumberOfGuests { get; set; }



        [Required(ErrorMessage = "Please enter the number of children below 5 years of age.")]
        [Display(Name = "Number of Children (Below 5 yrs)")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number of children.")]
        public int NumberOfChildren { get; set; }



        public List<string> AvailableRoomTypes { get; set; }







        public decimal TotalPrice { get; set; }
    }
}
