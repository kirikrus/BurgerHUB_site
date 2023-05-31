namespace BurgerHUB.Models
{
    public class BurgerCons
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public ulong Price { get; set; }
        public int Weight_gram { get; set; }
        public int IDSupplement { get; set; }
        public int Supplement { get; set; } // кбжу
        public List<Ingridient> Ingridients { get; set; }
    }
}
