using BurgerHUB.Models;

namespace BurgerHUB.Data.Models
{
    public class Position
    {
        public int Id { get; set; }
        public BurgerMenu BM { get; set; }
        public BurgerCons BC { get; set; }
        public int AmountBM { get; set; }
        public int AmountBC { get; set; }
    }
}
