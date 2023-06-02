using BurgerHUB.Models;

namespace BurgerHUB.Data.Models
{
    public class Supplement
    {
        public Supplement(int proteins, int fasts, int carbohydrates, int calories)
        {
            this.proteins = proteins;
            this.fasts = fasts;
            this.carbohydrates = carbohydrates;
            this.calories = calories;
        }
        public int Id { get; set; }
        public int proteins { get; set; }
        public int fasts { get; set; }
        public int carbohydrates { get; set; }
        public int calories { get; set; }
        public int IdBurgerMenu { get; set; }
        public int IdBurgerCons { get; set; }
        public int IdIngridient { get; set; }
        public virtual BurgerMenu BurgerMenu { get; set; }
        public virtual BurgerCons BurgerCons { get; set; }
        public virtual Ingridient Ingridient { get; set; }
    }
}
