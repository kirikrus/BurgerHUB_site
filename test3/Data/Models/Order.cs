namespace BurgerHUB.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdDeliveryMan { get; set; }
        public int IdPayment { get; set; }
        public int IdPosition { get; set; }
        public List<Position> Positions { get; set; }

    }
}
