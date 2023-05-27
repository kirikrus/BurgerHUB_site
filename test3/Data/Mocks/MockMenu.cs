using BurgerHUB.Models;
using BurgerHUB.Data.Interfaces;

namespace BurgerHUB.Mocks
{
    public class MockMenu : IMenu
    {
        public IEnumerable<BurgerIDMenu> BurgersMenu
        {
            get
            {
                return new List<BurgerIDMenu>
                {
                    new BurgerIDMenu
                    {
                        Name = "Black classic",
                        Description = "very nice",
                        IMG = "https://static.tildacdn.com/tild3733-3364-4438-b435-313535653861/6041e3c391768.png",
                        Price = 600,
                        IsEco = false,
                        IsHit = true,
                        CookTime_sec = 600,
                        Weight_gram = 250,
                        Supplement = 1200,
                    },
                    new BurgerIDMenu
                    {
                        Name = "Eco burger",
                        Description = "vegan",
                        IMG = "https://img.povar.ru/uploads/53/21/e4/29/veganskii_burger-578529.jpg",
                        Price = 900,
                        IsEco = false,
                        IsHit = true,
                        CookTime_sec = 20,
                        Weight_gram = 200,
                        Supplement = 900,
                    },
                };
            }
        }
    }
}

