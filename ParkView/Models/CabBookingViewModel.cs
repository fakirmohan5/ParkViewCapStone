namespace ParkView.Models
{
    public class CabBookingViewModel
    {
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public double PickupLocationLatitude { get; set; }
        public double PickupLocationLongitude { get; set; }
        public double DropoffLocationLatitude { get; set; }
        public double DropoffLocationLongitude { get; set; }
    }
}
