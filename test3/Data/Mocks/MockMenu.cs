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
                        Name = "Black Classic",
                        Description = "Это бургер, которому нет равных. " +
                        "Неожиданное сочетание вишни и мраморной говядины " +
                        "не оставляет равнодушными даже самых скептически" +
                        " настроеннных гостей.",
                        Composition = "Соевый стейк, соус тайская сальса, соус гуакамолле, свежий редис, " +
                        "специя фурикаки, огурец свежий, красный лук, кинза,булочка для гамбургера с кунжутом, " +
                        "соус Бешамель",
                        IMG = "/img/Black_Classic.png",
                        Price = 400,
                        IsEco = false,
                        IsHit = true,
                        CookTime_sec = 25,
                        Weight_gram = 487,
                        Supplement = 706,
                    },
                    new BurgerIDMenu
                    {
                        Name = "Гурмяу",
                        Description = "Соевый стейк, соус тайская сальса, " +
                        "соус гуакамолле, свежий редис, специя " +
                        "фурикаки, огурец свежий, красный лук, " +
                        "кинза...\r\nИ лучше описания не придумать.",
                        Composition = "Копченый сыр сулугуни, лук конфи, говяжья котлета, " +
                        "пивной соус, булочка для гамбургера с кунжутом",
                        IMG = "/img/Gurmyau.png",
                        Price = 900,
                        IsEco = true,
                        IsHit = true,
                        CookTime_sec = 20,
                        Weight_gram = 400,
                        Supplement = 200,
                    },
                };
            }
        }
    }
}

