using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using BurgerHUB.Controllers;
using BurgerHUB.Data.Models;
using BurgerHUB.Data.Mocks;

namespace BurgerHUB.Pages
{
	public class ProfileModel : PageModel
	{
		public readonly IClients _Client;
		public readonly IMenu _Menu;
		public ProfileModel(IClients client, IMenu menu)
		{
			_Client = client;
			_Menu = menu;
		}

		public static int activeID;
		public Client ActiveClient;
		public IEnumerable<BurgerMenu> Menu;

		public void UpdatePositions(int burgerId)
		{
			Position NewPosition = new();
			ActiveClient = ListClass.Base.FirstOrDefault(x => x.Id == activeID);
			Order ActiveOrder = ActiveClient.OrderHistory.First();
			if (ActiveOrder.IsActive == -1) 
			{
				ActiveOrder.Positions.Clear();
				ActiveOrder.IsActive = 1;
			}
			else
			{
				ActiveOrder = ActiveClient.OrderHistory.FirstOrDefault(x => x.IsActive == 1);
			}
			if(burgerId > 0 && burgerId <= _Menu.BurgersMenu.Count())
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
			ActiveClient.OrderHistory.RemoveAll(x => x.IsActive == 1);
			ActiveClient.OrderHistory.Add(ActiveOrder);
			ListClass.Base.RemoveAll(x => x.Id == activeID);
			ListClass.Base.Add(ActiveClient);
		}

		public PageResult OnGet(int ID)
		{
			activeID = ID;
			if(ListClass.Base.Count == 0) 
				ListClass.Base = _Client.Clients.ToList();
			ActiveClient = ListClass.Base.FirstOrDefault(x => x.Id == ID);
			Menu = _Menu.BurgersMenu;
			return Page();
		}
	}
}