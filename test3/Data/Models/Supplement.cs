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
    }
}
