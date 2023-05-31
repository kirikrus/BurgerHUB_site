using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using BurgerHUB.Controllers;

namespace BurgerHUB.Pages
{
	public class ProfileModel : PageModel
	{
		public readonly IClients _Client;
		public ProfileModel(IClients client)
		{
			_Client = client;
		}
		public Client ActiveClient;
		public PageResult OnGet(int ID)
		{
			ActiveClient = _Client.Clients.FirstOrDefault(x => x.ID == ID);
			return Page();
		}
	}
}