

using BurgerHUB.Data.Models;

namespace BurgerHUB.Models
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight_gram { get; set; }
        public string IMG_top { get; set; }
        public string IMG_side { get; set; }
        public int IdSupplement { get; set; }
        public virtual Supplement Supplement { get; set; }
        public virtual BurgerCons BurgerCons { get; set; }
    }
}
