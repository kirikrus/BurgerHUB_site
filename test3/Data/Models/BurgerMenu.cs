
namespace BurgerHUB.Models
{
    public class BurgerMenu
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Composition { get; set; }
        public string IMG { get; set; } // URL image
        public ulong Price { get; set; }
        public int IsEco { get; set; }
        public int IsHit { get; set; }
        public int CookTime_min { get; set; }
        public int Weight_gram { get; set;}
        public int IDSupplement { get; set; }
        public int Supplement { get; set; } // кбжу
    }
}
