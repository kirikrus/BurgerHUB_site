using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class GetLogin
{
    public string Email { get; set; }
    public string Password { get; set; }
}

namespace BurgerHUB.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ClientsController : Controller
    {
        private readonly IClients List;
        public ClientsController(IClients list)
        {
            List = list;
        }
        [HttpPost]
        [Route("ProcessLoginForm")]
        public IActionResult ProcessLoginForm([FromBody] GetLogin model)
        {
            string NewEmail = model.Email;
            string NewPassword = model.Password;
            IEnumerable<Client> AllClients;
            AllClients = List.Clients;
            while (true)
            {
                foreach (var Client in AllClients)
                {
                    if (Client.Email == NewEmail || Client.Password == NewPassword)
                    {
                        return Json(new { success = true });
                    }
                }
                break;
            }
            return Json(new { success = false });
        }
    }
}
