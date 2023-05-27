using BurgerHUB.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerHUB.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenu _burgers;

        public MenuController(IMenu burgers)
        {
            _burgers = burgers;
        }
        public ViewResult ShowMenu()
        {
            //MenuViewModel obj = new MenuViewModel();
            return View(); 
        }

    }
}