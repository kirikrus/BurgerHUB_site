using BurgerHUB.Data.Enum;

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
        public Supplement Supplement { get; set; }
    }
}
