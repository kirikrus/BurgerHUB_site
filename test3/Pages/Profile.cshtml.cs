using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using BurgerHUB.Controllers;
using BurgerHUB.Data.Models;

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
		public Order ActiveOrder;
		public void UpdatePositions(int burgerId)
		{
			Position newposition = new();
			if (ActiveOrder.Positions.Count == null) 
			{
				ActiveOrder.IsActive = 0;
				ActiveClient.OrderHistory.Add(ActiveOrder);
			}
			if(burgerId > 0 && burgerId < 8)
			{
				int flag = 0;
				foreach (var x in ActiveOrder.Positions)
				{
					if(burgerId == x.BM)
					{
						x.AmountBM += 1;
						flag += 1;
						break;
					}
				}
				if (flag == 0)
				{
					newposition.BM = burgerId;
					newposition.AmountBM = 1;
					ActiveOrder.Positions.Add(newposition);
				}
			}
			else
			{
				int flag = 0;
				foreach (var x in ActiveOrder.Positions)
				{
					if (burgerId == x.BC)
					{
						x.AmountBC += 1;
						flag += 1;
						break;
					}
				}
				if (flag == 0)
				{
					newposition.BC = burgerId;
					newposition.AmountBC = 1;
					ActiveOrder.Positions.Add(newposition);
				}
			}
		}
		public PageResult OnGet(int ID)
		{
			ActiveClient = _Client.Clients.FirstOrDefault(x => x.ID == ID);
			//ActiveOrder = ActiveClient.OrderHistory.Find(x => x.IsActive == 0);
			return Page();
		}
	}
}