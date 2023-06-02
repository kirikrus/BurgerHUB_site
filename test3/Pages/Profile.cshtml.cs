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
		public static int activeID;
		public Client ActiveClient;
		//public	Order ActiveOrder;
		public void UpdatePositions(int burgerId)
		{
			Position NewPosition = new();
			ActiveClient = _Client.Clients.FirstOrDefault(x => x.Id == activeID);
			Order ActiveOrder = ActiveClient.OrderHistory.First();
			if (ActiveClient.OrderHistory?.Count == 0) 
			{
				ActiveClient.OrderHistory.Add(ActiveOrder);
			}
			else
			{
				ActiveOrder = ActiveClient.OrderHistory.FirstOrDefault(x => x.IsActive == 0);
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
					NewPosition.BM = burgerId;
					NewPosition.AmountBM = 1;
					ActiveOrder.Positions.Add(NewPosition);
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
					NewPosition.BC = burgerId;
					NewPosition.AmountBC = 1;
					ActiveOrder.Positions.Add(NewPosition);
				}
			}
			ActiveClient.OrderHistory.RemoveAll(x => x.IsActive == 0);
			ActiveClient.OrderHistory.Add(ActiveOrder);
		}
		public PageResult OnGet(int ID)
		{
			activeID = ID;
			ActiveClient = _Client.Clients.FirstOrDefault(x => x.Id == ID);
			return Page();
		}
	}
}