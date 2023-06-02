using BurgerHUB.Data.Interfaces;
using BurgerHUB.Data.Models;
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
                        Id= 0001,
                        Name = "Vlad",
                        LastName = "Hom",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "dsf@sdf.ru",
                        PhoneNumber = 89167374222,
                        Password = "adsfe3244",
                        ClientAdress = "Shop street 28",
                        OrderHistory = new List<Order> ()
                        {
                            new Order
                            {
                                Id = 1,
                                IsActive = 1,
								IdPayment =1,
								Payment = new Payment()
								{
									Id = 1,
									CardNumber = "4377 7278 1972 3649" ,
									IdOrder = 1,
									Name = "Vlad",
									LastName = "Hom",
									Validity = "10/28",
								},

								IdDeliveryMan =1,
								DeliveryMan = new DeliveryMan()
								{
									Name = "Василий",
									LastName = "Иванов",
									PhoneNumber = 89926562311,
									IdOrder = 1,
								},
                                Positions = new List<Position?> ()
                                {
                                   new Position
                                   {
                                       BC = 0,
                                       BM = 1,
                                       AmountBC = 0,
                                       AmountBM = 2,
                                   }
                                },
                            },
							new Order
							{
								Id = 2,
								IsActive = 0,
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 2,
								   }
								},
							},
							new Order
							{
								Id = 3,
								IsActive = 0,
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 4,
								   }
								},
							}
						},
                    },
                    new Client
                    {
                        Id=0002,
                        Name = "Max",
                        LastName = "Hin",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "werwer@sdf.ru",
                        PhoneNumber = 89127374222,
                        Password = "ad23542345",
                        ClientAdress = "Down street 45",
						OrderHistory = new List<Order> ()
						{
							new Order
							{
								Id = 1,
								IsActive = 1,
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 2,
								   }
								},
								IdPayment =2,
								Payment = new Payment()
								{
									Id = 2,
									CardNumber = "4377 7278 1972 3649" ,
									IdOrder = 1,
									Name = "Vlad",
									LastName = "Hom",
									Validity = "10/28",
								},
								IdDeliveryMan = 1,
								DeliveryMan = new DeliveryMan()
								{
									Name = "Василий",
									LastName = "Иванов",
									PhoneNumber = 89926562311,
									IdOrder = 4,
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 1,
								   }
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 2,
								   }
								},
							}
						},
					}
                };
            }
        }
	}
}