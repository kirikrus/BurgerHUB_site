using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using BurgerHUB.Pages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Dynamic;

public class GetLogin
{
	public string Email { get; set; }
	public string Password { get; set; }
}

namespace BurgerHUB.Controllers
{
	[Route("[Controller]")]
	public class ClientsController : Controller
	{
		private readonly IClients List;
		public ClientsController(IClients list)
		{
			List = list;
		}
		[HttpPost]
		[Route("ProcessLoginForm")]
		public IActionResult ProcessLoginForm([FromBody] GetLogin model)
		{
			string NewEmail = model.Email;
			string NewPassword = model.Password;
			IEnumerable<Client> AllClients;
			AllClients = List.Clients.ToList();
			while (true)
			{
				foreach (var Client in AllClients)
				{
					if (Client.Email == NewEmail && Client.Password == NewPassword)
					{
						return Json(new {success = true, client = Client.Id, });
					}
				} 
				break;
			}
			return Json(new { success = false });
		}
	}
}
