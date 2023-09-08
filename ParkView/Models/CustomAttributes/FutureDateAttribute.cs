using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace ParkView.Models.Custom_Attributes
{
    public class FutureDateAttribute : ValidationAttribute
    {


        public override bool IsValid(object value)
        {
            DateTime date = Convert.ToDateTime(value);
            return date >= DateTime.Now.Date;
        }


    }
}
