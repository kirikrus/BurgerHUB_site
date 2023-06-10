using BurgerHUB.Data.Models;
using BurgerHUB.Models;
using Microsoft.EntityFrameworkCore;
namespace BurgerHUB.Data
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (context.BurgerMenus.Any())
            {
                // База данных уже заполнена данными, поэтому нет необходимости в дополнительном заполнении.
                return;
            }

            var BurgerMenus = new List<BurgerMenu>
        {
             new BurgerMenu
                    {
                        Id = 1,
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
                        IsEco = 0,
                        IsHit = 1,
                        CookTime_min = 25,
                        Weight_gram = 487,
                        Supplement = new Supplement(40, 62, 200, 706),
                    },
                    new BurgerMenu
                    {
                        Id = 2,
                        Name = "Гурмяу",
                        Description = "Соевый стейк, соус тайская сальса, " +
                        "соус гуакамолле, свежий редис, специя " +
                        "фурикаки, огурец свежий, красный лук, " +
                        "кинза...\r\nИ лучше описания не придумать.",
                        Composition = "Копченый сыр сулугуни, лук конфи, говяжья котлета, " +
                        "пивной соус, булочка для гамбургера с кунжутом",
                        IMG = "/img/Gurmyau.png",
                        Price = 900,
                        IsEco = 1,
                        IsHit = 0,
                        CookTime_min = 20,
                        Weight_gram = 400,
                        Supplement = new Supplement(5, 10, 50, 200),
                    },
                    new BurgerMenu
                    {
                        Id = 3,
                        Name = "Eco Burger",
                        Description = "Это бургер, для настоя" +
                        "щего вегана или ценителя полезной пищи. Ec" +
                        "o Burger полностью изготовлен из растительных" +
                        " игридиентов." +
                        " Его главной осмобенност" +
                        "ь является пикантно розовая свекольная булочка.",
                        Composition = "Соевая котлета, соус тай" +
                        "ская сальса, лук красный, лук конфи" +
                        ", базилик, редис, кинза,свекольная булочка для гамбургера",
                        IMG = "/img/Eco_Burger.png",
                        Price = 700,
                        IsEco = 1,
                        IsHit = 0,
                        CookTime_min = 15,
                        Weight_gram = 417,
                        Supplement = new Supplement(4, 13, 67, 332),
                    },
                    new BurgerMenu
                    {
                        Id = 4,
                        Name = "Митон",
                        Description = "Рецепт 'Митона' был разработан таким " +
                        "образом, чтобы сочетаться с пивом, коего в баре великое м" +
                        "ножество. Копченый сыр сулугуни, лук конфи и говяжья котле" +
                        "та — бомбическое сочетание и" +
                        " само по себе, а вместе с крафтом — и вовсе гастрономический рай..",
                        Composition = "Копченый сыр сулугуни, лук" +
                        " конфи, говяжья котле" +
                        "та, пивной соу" +
                        "с, булочка для гамбургера с кунжутом",
                        IMG = "/img/Miton.png",
                        Price = 550,
                        IsEco = 0,
                        IsHit = 0,
                        CookTime_min = 20,
                        Weight_gram = 554,
                        Supplement = new Supplement(25, 41, 120, 627),
                    },
                    new BurgerMenu
                    {
                        Id = 5,
                        Name = "Не Митон",
                        Description = "Рецепт 'Митона' был разработан таким " +
                        "образом, чтобы сочетаться с пивом, коего в баре великое м" +
                        "ножество. Копченый сыр сулугуни, лук конфи и говяжья котле" +
                        "та — бомбическое сочетание и" +
                        " само по себе, а вместе с крафтом — и вовсе гастрономический рай..",
                        Composition = "Копченый сыр сулугуни, лук" +
                        " конфи, говяжья котле" +
                        "та, пивной соу" +
                        "с, булочка для гамбургера с кунжутом",
                        IMG = "/img/Miton.png",
                        Price = 550,
                        IsEco = 0,
                        IsHit = 0,
                        CookTime_min = 20,
                        Weight_gram = 554,
                        Supplement = new Supplement(25, 41, 120, 627),
                    },
                    new BurgerMenu
                    {
                        Id = 6,
                        Name = "Вкусный бургер",
                        Description = "Рецепт 'Митона' был разработан таким " +
                        "образом, чтобы сочетаться с пивом, коего в баре великое м" +
                        "ножество. Копченый сыр сулугуни, лук конфи и говяжья котле" +
                        "та — бомбическое сочетание и" +
                        " само по себе, а вместе с крафтом — и вовсе гастрономический рай..",
                        Composition = "Копченый сыр сулугуни, лук" +
                        " конфи, говяжья котле" +
                        "та, пивной соу" +
                        "с, булочка для гамбургера с кунжутом",
                        IMG = "/img/Miton.png",
                        Price = 550,
                        IsEco = 0,
                        IsHit = 0,
                        CookTime_min = 20,
                        Weight_gram = 554,
                        Supplement = new Supplement(25, 41, 120, 627),
                    },
        };

            context.BurgerMenus.AddRange(BurgerMenus);
            context.SaveChanges();
        }
    }
}