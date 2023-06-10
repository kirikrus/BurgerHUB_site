using BurgerHUB.Data.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerHUB.Models
{
    public class Client
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
        public virtual List<Order> OrderHistory { get; set; }
        public virtual List<BurgerCons> MyBurgers { get; set; }

//        [InverseProperty("Client")]
        //public virtual Order Order { get; set; }
    }
}
