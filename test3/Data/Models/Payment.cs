namespace BurgerHUB.Data.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Validity { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
