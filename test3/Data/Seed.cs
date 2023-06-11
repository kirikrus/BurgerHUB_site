using BurgerHUB.Data.Interfaces;
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
            context.Database.EnsureCreated();
            var Clients = new List<Client>
            {
                new Client
                {
                    Id=1,
                    Name="Влад",
                    Avatar="фотка",
                    LastName="Хомс",
                    Raiting=4,
                    Email = "dsf@sdf.ru",
                    PhoneNumber = 89167374222,
                    Password = "adsfe3244",
                    ClientAdress = "Улица Ленина, дом 28, квартира 23",
                    //OrderHistory=new List<Order>()
                    //{
                    //    new Order
                    //    {
                    //        Id=1,
                    //        IsActive=1,
                    //        Payment=new Payment()
                    //        {
                    //            Id=1,
                    //            CardNumber="4377 7278 1972 3649",
                    //            Name="Влад",
                    //            LastName="Хомс",
                    //            Validity="10/28"
                    //        },
                    //    //    Positions = new List<Position?> ()
                    //    //        {
                    //    //           new Position
                    //    //           {
                    //    //               BC = 0,
                    //    //               BM = 1,
                    //    //               AmountBC = 0,
                    //    //               AmountBM = 20,
                    //    //           },
                    //    //},
                    //}
                    //},
                },
                new Client
                {
                    Id=2,
                    Name="Максим",
                    Avatar="фотка",
                    LastName="Ханов",
                    Raiting=1,
                    Email="werwer@sdf.ru",
                    PhoneNumber = 89127374222,
                    Password = "ad23542345",
                    ClientAdress = "Нижня парковая, дом 24, квартира 2",
                //    OrderHistory = new List<Order> ()
                //        {
                //            new Order
                //            {
                //                Id = 1,
                //                IsActive = 1,
                //                //Positions = new List<Position?> ()
                //                //{
                //                //   new Position
                //                //   {
                //                //       BC = 0,
                //                //       BM = 2,
                //                //       AmountBC = 0,
                //                //       AmountBM = 2,
                //                //   }
                //                //},
                //},
                //    },
                },
                new Client
                {
                    Id=3,
                    Name="Николай",
                    Avatar="фотка",
                    LastName="Абрамов",
                    Raiting=2,
                    Email="oiasdas@sdf.ru",
                    PhoneNumber = 89127374112,
                    Password = "ad4as5",
                    ClientAdress = "Верхняя парковая, дом 2, квартира 8",
                },
            };

            context.Clients.AddRange(Clients);
            context.SaveChanges();
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