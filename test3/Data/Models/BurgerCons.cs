using BurgerHUB.Data.Models;

namespace BurgerHUB.Models
{
    public class BurgerCons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ulong Price { get; set; }
        public int Weight_gram { get; set; }
        public int IDSupplement { get; set; }
        public int IdPosition { get; set; }
        public virtual Supplement Supplement { get; set; } // кбжу
        public virtual List<Ingridient> Ingridients { get; set; }
        public virtual Position Position { get; set; }
    }
}
