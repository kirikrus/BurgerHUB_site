using BurgerHUB.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerHUB.Data.Models
{
    public class Order
    {
        
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int IsActive { get; set; }
        public virtual List<Position> Positions { get; set; }
        public virtual Client Client { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }
        public virtual Payment Payment { get; set; }
        //public virtual Position Position { get; set; }
    }
}
