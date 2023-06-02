using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using BurgerHUB.Pages;
using Microsoft.AspNetCore.Mvc;
public struct GetBurgerID
{
	public int BurgerID { get; set; }
}
namespace BurgerHUB.Controllers
{ 
	[Route("[Controller]")]
	public class ShopBasketController : Controller
	{
		private readonly IClients _profileModel;
		public ShopBasketController(IClients profileModel)
		{
			_profileModel = profileModel;
		}
		[HttpPost]
		[Route("GetPositionOrder")]
		public IActionResult GetPositionOrder([FromBody] GetBurgerID model)
		{
			int ID = model.BurgerID;
			ProfileModel test = new(_profileModel);
			test.UpdatePositions(ID);
			return Json(new { success = true });
		}
	}
}
