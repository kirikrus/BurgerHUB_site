using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace BurgerHUB.Models
{
    public class ClientID
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string LastName { get; set; }
        public int Raiting { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ClientAdress { get; set; }
        public OrderHistory OrderHistory { get; set; }
        public List<BurgerIDCons> MyBurgers { get; set; }
}
}
