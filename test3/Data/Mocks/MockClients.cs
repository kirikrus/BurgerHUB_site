using BurgerHUB.Interfaces;
using BurgerHUB.Models;

namespace BurgerHUB.Mocks
{
    public class MockClients : IClients
    {
        public IEnumerable<ClientID> Clients
        {
            get
            {
                return new List<ClientID>
                {
                    new ClientID
                    {
                        Name = "Vlad",
                        LastName = "Hom",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "dsf@sdf.ru",
                        PhoneNumber = 89167374222,
                        Password = "adsfe3244",
                        ClientAdress = "Shop street 28",
                        OrderHistory = new OrderHistory
                        {

                        },
                        MyBurgers = new List<BurgerIDCons>
                        {

                        }
                    },
                    new ClientID
                    {
                        Name = "Max",
                        LastName = "Hin",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "werwer@sdf.ru",
                        PhoneNumber = 89127374222,
                        Password = "ad23542345",
                        ClientAdress = "Down street 45",
                        OrderHistory = new OrderHistory
                        {

                        },
                        MyBurgers = new List<BurgerIDCons>
                        {

                        }
                    }
                };
            }
        }
    }
}