using System.ComponentModel.DataAnnotations;


namespace ParkView.Models.Custom_Attributes
{
    public class AdvanceCheckoutDateAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = Convert.ToDateTime(value);
            //return date >= DateTime.Now.Date;
            return date >= DateTime.Now.AddDays(1);
        }
    }
}
