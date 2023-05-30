using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;

namespace BurgerHUB.Mocks
{
    public class MockClients : IClients
    {
        public IEnumerable<Client> Clients
        {
            get
            {
                return new List<Client>
                {
                    new Client
                    {
                        Name = "Vlad",
                        LastName = "Hom",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "dsf@sdf.ru",
                        PhoneNumber = 89167374222,
                        Password = "adsfe3244",
                        ClientAdress = "Shop street 28",
                    },
                    new Client
                    {
                        Name = "Max",
                        LastName = "Hin",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "werwer@sdf.ru",
                        PhoneNumber = 89127374222,
                        Password = "ad23542345",
                        ClientAdress = "Down street 45",
                    }
                };
            }
        }
    }
}