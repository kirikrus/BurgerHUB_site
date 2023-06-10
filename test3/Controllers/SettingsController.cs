using Microsoft.AspNetCore.Mvc;

namespace BurgerHUB.Controllers
{
	public class SettingsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
