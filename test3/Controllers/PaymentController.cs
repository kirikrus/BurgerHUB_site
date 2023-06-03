using Microsoft.AspNetCore.Mvc;

namespace BurgerHUB.Controllers
{
	public class PaymentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
