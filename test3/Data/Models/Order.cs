namespace BurgerHUB.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int IdClient { get; set; }
        public int IdDeliveryMan { get; set; }
        public int IdPayment { get; set; }
        public int IdPosition { get; set; }
        public int IsActive { get; set; }
		public int Price { get; set; }
		public string AdressDilivery { get; set; }
		public List<Position> Positions { get; set; }

    }
}
