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
	public string Password { get; set; }
	public string Email{ get; set; }
	public string Tel { get; set; }
	public string Adres { get; set; }
}

namespace BurgerHUB.Controllers
{
	[Route("[Controller]")]
	public class RegistrationController : Controller
	{
        private readonly DataContext _context;
		public RegistrationController(DataContext context)
		{
            _context = context;
        }
		[HttpPost]
		[Route("ProcessRegistrationForm")]
		public IActionResult ProcessRegistrationForm([FromBody] Get model)
		{
			string _Email = model.Email;
			string _Password = model.Password;
			string _SurName = model.Surname;
			string _Adress = model.Adres;
			string _Name = model.Name;
			int _PhoneNumber;
			{ try { _PhoneNumber = Convert.ToInt32(model.Tel);} catch { return Json(new { success = false });} }

			List<Client> AllClients;
			AllClients = _context.Clients.ToList();
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
				Avatar = "фотка",
				OrderHistory = new List<Order>()
				{
					new Order
					{
						Id = _context.Orders.ToList().Count + 1,
						Date = "",
						Time = "",
						IsActive = -1,
						DeliveryMan = _context.DeliveryMen.ToList().FirstOrDefault(),
						Payment = new Payment()
						{
							 Id = _context.Payments.ToList().Count + 1,
							 CardNumber = "",
							 Name = "",
							 LastName = "",
							 Validity = "",
						},
						Positions = new List<Position> ()
						{
							new Position
							{
								Id = _context.Positions.ToList().Count + 1,
                                BM = 0,
                                BC = 0,
                                AmountBC = 0,
                                AmountBM = 0,
                            }
						}
					}
				}
			};
			_context.Clients.Add(ActiveClient);
			_context.SaveChanges();
			return Json(new { success = true, client = ActiveClient.Id });
		}
	}
}