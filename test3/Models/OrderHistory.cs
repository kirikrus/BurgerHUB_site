namespace BurgerHUB.Models
{
    public class OrderHistory
    {
        public List<Position> Positions { get; set; }
        public string Data { get; set; }
        public string AdressDilivery { get; set; }
        public int Time { get;}
        public decimal Price { get;}
    }
    public struct Position
    {
       public BurgerIDMenu BM { get; set; }
       public BurgerIDCons BC { get; set; }
       public int AmountBM { get; set; }
       public int AmountBC { get; set; }
    }
}