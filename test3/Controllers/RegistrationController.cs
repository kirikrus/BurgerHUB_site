using BurgerHUB.Data.Interfaces;
using BurgerHUB.Data.Mocks;
using BurgerHUB.Data.Models;
using BurgerHUB.Models;
using BurgerHUB.Pages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Dynamic;

public class Get
{
	public string Surname { get; set; }
	public string Name { get; set; }
	public string Patronymic { get; set; }
	public string Email{ get; set; }
	public string Tel { get; set; }
	public string Adres { get; set; }
}

namespace BurgerHUB.Controllers
{
	[Route("[Controller]")]
	public class RegistrationController : Controller
	{
		private readonly IClients List;
		private ListClass _Active;
		public RegistrationController(IClients list)
		{
			List = list;
		}
		[HttpPost]
		[Route("ProcessRegistrationForm")]
		public IActionResult ProcessRegistrationForm([FromBody] Get model)
		{
			string _Email = model.Email;
			string _Password = model.Patronymic;
			string _SurName = model.Surname;
			string _Adress = model.Adres;
			string _Name = model.Name;
			int _PhoneNumber;
			{ try { _PhoneNumber = Convert.ToInt32(model.Tel);} catch { return Json(new { success = false });} }
			List<Client> AllClients;
			AllClients = List.Clients.ToList();
			while (true)
			{
				foreach (var Client in AllClients)
				{
					if (Client.Email == _Email)
					{
						return Json(new { success = false });
					}
				}
				break;
			}
			Client ActiveClient = new Client()
			{
				Id = AllClients.Count + 1,
				Raiting = 1,
				Name = _Name,
				LastName = _SurName,
				PhoneNumber = _PhoneNumber,
				Email = _Email,
				Password = _Password,
				ClientAdress = _Adress,
				OrderHistory = new List<Order>()
				{
					new Order
					{
						IsActive = -1,
						Positions = new List<Position?> ()
						{
							new Position{}
						}
					}
				}
			};
			ListClass.Base.Add(ActiveClient);
			return Json(new { success = true, client = ActiveClient.Id });
		}
	}
}