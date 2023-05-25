using BurgerHUB.Interfaces;
using BurgerHUB.ViewModels;
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
            AuthorizationViewModel obj = new AuthorizationViewModel();
            obj.Clients = _Clients.Clients;
            //var Clients = _Clients.Clients; // в интерфейсе IClients есть IEnumerable<ClientID> Clients
            return View(); // твоя страница авторизации
        }

    }
}
