
using BurgerHUB.Data.Models;

namespace BurgerHUB.Models
{
    public class BurgerMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Composition { get; set; }
        public string IMG { get; set; } // URL image
        public ulong Price { get; set; }
        public int IsEco { get; set; }
        public int IsHit { get; set; }
        public int CookTime_min { get; set; }
        public int Weight_gram { get; set; }
        public int IDSupplement { get; set; }
        public int IdPosition { get; set; }
        public virtual Supplement Supplement { get; set; } // кбжу
        public virtual Position Position { get; set; }
    }
}
