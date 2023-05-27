using BurgerHUB.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerHUB.Controllers
{
    public class ClientsConroller : Controller
    {
        private readonly IClients _Clients;

        public ClientsConroller(IClients _clients) 
        { 
            _Clients = _clients;
        }
        public ViewResult Authorization()
        {
            //AuthorizationViewModel obj = new AuthorizationViewModel();
            //obj.Clients = _Clients.Clients;
            return View(); // твоя страница авторизации
        }

    }
}
