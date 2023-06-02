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
		private readonly IMenu _M;
		public ShopBasketController(IClients profileModel, IMenu M)
		{
			_profileModel = profileModel;
			_M = M;
		}
		[HttpPost]
		[Route("GetPositionOrder")]
		public IActionResult GetPositionOrder([FromBody] GetBurgerID model)
		{
			int ID = model.BurgerID;
			ProfileModel test = new(_profileModel, _M);
			test.UpdatePositions(ID);
			return Json(new { success = true });
		}
	}
}
