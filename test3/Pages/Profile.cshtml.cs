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
        private readonly DataContext _context;

        public ProfileModel(DataContext context)
		{
            _context = context;
        }

		public static int activeID;
		public Client ActiveClient;
		public IEnumerable<BurgerMenu> Menu;

		public void UpdatePositions(int burgerId)
		{
			Position NewPosition = new();
            Position OldPosition = new();
            //ActiveClient = ListClass.Base.FirstOrDefault(x => x.Id == activeID);
            ActiveClient = _context.Clients.FirstOrDefault(x => x.Id == activeID);

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
			if(burgerId > 0 && burgerId <= _context.BurgerMenus.Count())
			{
				int flag = 0;
				foreach (var x in ActiveOrder.Positions)
				{
					if(burgerId == x.BM)
					{
						//OldPosition = x;
						x.AmountBM += 1;
						flag += 1;
						NewPosition = x;
						_context.SaveChanges();
						//OldPosition.AmountBM -= 1;
						break;
					}
				}
				if (flag == 0)
				{
					NewPosition.BM = burgerId;
					NewPosition.AmountBM = 1;
					NewPosition.Id = _context.Positions.Count() + 1;
					ActiveOrder.Positions.Add(NewPosition);
                    _context.SaveChanges();
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
			//ActiveClient.OrderHistory.RemoveAll(x => x.IsActive == 1);
			//ActiveClient.OrderHistory.Add(ActiveOrder);
			//if(OldPosition != null)
			//{
   //             _context.Positions.Remove(OldPosition);
   //             _context.Positions.Add(NewPosition);
   //         }
			//else
   //             _context.Positions.Add(NewPosition);
			//_context.SaveChanges();
			//ListClass.Base.RemoveAll(x => x.Id == activeID);
			//ListClass.Base.Add(ActiveClient);
		}

		public PageResult OnGet(int ID)
		{
			activeID = ID;
			ActiveClient = _context.Clients.ToList().FirstOrDefault(x => x.Id == ID);
			Menu = _context.BurgerMenus.ToList();
            //if(ListClass.Base.Count == 0) 
            //	ListClass.Base = _Client.Clients.ToList();

            //ActiveClient = ListClass.Base.FirstOrDefault(x => x.Id == ID);
            //Menu = _Menu.BurgersMenu;
            return Page();
		}
	}
}