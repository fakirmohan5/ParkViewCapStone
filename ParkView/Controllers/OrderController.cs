using Microsoft.AspNetCore.Mvc;
using ParkView.Data;
using ParkView.Models.Domain;
using ParkView.Models;

using Microsoft.EntityFrameworkCore;
using Razorpay.Api;
using Microsoft.AspNetCore.Authorization;

namespace ParkView.Controllers
{
	[Authorize]
	public class OrderController : Controller
	{
		private readonly ParkViewDbContext parkViewDbContext;

		public OrderController(ParkViewDbContext parkViewDbContext)
		{
			this.parkViewDbContext = parkViewDbContext;
		}
		[BindProperty]
		public OrderEntity _OrderDetails { get; set; }

        

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult InitiateOrder()
		{
			string key = "rzp_test_cgwSYT18Z5V2RG";
			string secret = "VU2yLzBEjCn5Fw6vkMfx4El5";

			Random _random = new Random();
			string TransactionId = _random.Next(0, 10000).ToString();

			Dictionary<string, object> input = new Dictionary<string, object>();
			input.Add("amount", Convert.ToDecimal(_OrderDetails.TotalAmount) * 100);
			input.Add("currency", "INR");
			input.Add("receipt", TransactionId);



			RazorpayClient client = new RazorpayClient(key, secret);
			Razorpay.Api.Order order = client.Order.Create(input);

			ViewBag.orderid = order["id"].ToString();
			return View("Payment", _OrderDetails);

		}

		public IActionResult Payment(string razorpay_payment_id, string razorpay_order_id, string razorpay_signature)
		{
			Dictionary<string, string> attributes = new Dictionary<string, string>();
			attributes.Add("razorpay_payment_id", razorpay_payment_id);
			attributes.Add("razorpay_order_id", razorpay_order_id);
			attributes.Add("razorpay_signature", razorpay_signature);

			Utils.verifyPaymentSignature(attributes);
			OrderEntity orderdetails = new OrderEntity();
			orderdetails.TransactionId = razorpay_payment_id;
			orderdetails.OrderId = razorpay_order_id;
			return View("PaymentSuccess", orderdetails);

        }



        
	}
}
