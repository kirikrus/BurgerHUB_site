﻿using BurgerHUB.Data.Interfaces;
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
		private readonly ProfileModel profileModel;
		public ShopBasketController(ProfileModel profileModel)
		{
			this.profileModel = profileModel;
		}
		[HttpPost]
		[Route("GetPositionOrder")]
		public IActionResult GetPositionOrder([FromBody] GetBurgerID model)
		{
			int ID = model.BurgerID;
			profileModel.UpdatePositions(ID);
			return Json(new { success = true });
		}
	}
}