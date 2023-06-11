using BurgerHUB.Data.Models;

namespace BurgerHUB.Models
{
    public class DeliveryMan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        //public int IdOrder { get; set; }
       public virtual List<Order> Order { get; set; }
    }
}
