using BurgerHUB.Data.Interfaces;
using BurgerHUB.Data.Mocks;
using BurgerHUB.Data.Models;
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
        private readonly DataContext _context;

        public ShopBasketController(DataContext context)
		{
            _context = context;
        }
		[HttpPost]
		[Route("GetPositionOrder")]
		public IActionResult GetPositionOrder([FromBody] GetBurgerID model)
		{
			int ID = model.BurgerID;
			ProfileModel test = new(_context);
			test.UpdatePositions(ID);
			return Json(new { success = true });
		}
	}
}
