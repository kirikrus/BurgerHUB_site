using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace BurgerHUB.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string LastName { get; set; }
        public int Raiting { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ClientAdress { get; set; }
        public int IDOrderHistiry { get; set; }
        public OrderHistory OrderHistory { get; set; }
        public List<BurgerCons> MyBurgers { get; set; }
}
}
