using BurgerHUB.Models;

namespace BurgerHUB.Data.Models
{
    public class Position
    {
        public int Id { get; set; }
        public int BM { get; set; }
        public int BC { get; set; }
        public int AmountBM { get; set; }
        public int AmountBC { get; set; }
        public virtual Order Order { get; set; }
        //public virtual BurgerMenu BurgerMenu { get; set; }
        //public virtual BurgerCons BurgerCons { get; set; }
    }
}
