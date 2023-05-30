using BurgerHUB.Data.Models;

namespace BurgerHUB.Models
{
    public class OrderHistory
    {
        public int ID { get; set; }
        public int IDPositions { get; set; }
        public List<Position> Positions { get; set; }
        public string Date { get; set; }
        public string AdressDilivery { get; set; }
        public int Time { get;}
        public decimal Price { get;}
    }
}