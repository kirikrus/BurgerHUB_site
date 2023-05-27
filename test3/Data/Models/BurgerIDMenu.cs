namespace BurgerHUB.Models
{
    public class BurgerIDMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Composition { get; set; }
        public string IMG { get; set; } // URL image
        public ulong Price { get; set; }
        public bool IsEco { get; set; }
        public bool IsHit { get; set; }
        public int CookTime_sec { get; set; }
        public int Weight_gram { get; set;}
        public int Supplement { get; set; } // кбжу
    }
}
