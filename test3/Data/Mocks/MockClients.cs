﻿using BurgerHUB.Data.Interfaces;
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
						Name = "Влад",
						LastName = "Хомс",
						Raiting = 4,
						Avatar = "фотка",
						Email = "dsf@sdf.ru",
						PhoneNumber = 89167374222,
						Password = "adsfe3244",
						ClientAdress = "Улица Ленина, дом 28, квартира 23",
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
									Name = "Влад",
									LastName = "Хомс",
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
									   AmountBM = 20,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 15,
								   }
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "10.05.22 15:33",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 2,
								   },
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
								Id = 3,
								IsActive = 0,
								Date = "8.04.22 19:03",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 3,
									   AmountBC = 0,
									   AmountBM = 4,
								   }
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "01.01.22 11:11",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 4,
									   AmountBC = 0,
									   AmountBM = 20,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 1,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 6,
								   }
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "29.12.21 11:05",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 4,
									   AmountBC = 0,
									   AmountBM = 2,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 1,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 6,
								   }
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "14.12.21 21:11",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 4,
									   AmountBC = 0,
									   AmountBM = 2,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 1,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 2,
									   AmountBC = 0,
									   AmountBM = 6,
								   }
								},
							},
						},

                    },
                    new Client
                    {
                        Id = 0002,
                        Name = "Максим",
                        LastName = "Ханов",
                        Raiting = 1,
                        Avatar = "фотка",
                        Email = "werwer@sdf.ru",
                        PhoneNumber = 89127374222,
                        Password = "ad23542345",
                        ClientAdress = "Нижня парковая, дом 24, квартира 2",
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
								IdPayment = 2,
								Payment = new Payment()
								{
									Id = 2,
									CardNumber = "4237 7128 1972 1149" ,
									IdOrder = 1,
									Name = "Максим",
									LastName = "Ханов",
									Validity = "9/28",
								},
								IdDeliveryMan = 1,
								DeliveryMan = new DeliveryMan()
								{
									Name = "Василий",
									LastName = "Иванов",
									PhoneNumber = 89926562311,
									IdOrder = 1,
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "15.12.19 11:11",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 4,
									   AmountBC = 0,
									   AmountBM = 1,
								   }
								},
							},
						},
					},
					new Client
					{
						Id = 0003,
						Name = "Николай",
						LastName = "Абрамов",
						Raiting = 2,
						Avatar = "фотка",
						Email = "oiasdas@sdf.ru",
						PhoneNumber = 89127374112,
						Password = "ad4as5",
						ClientAdress = "Верхняя парковая, дом 2, квартира 8",
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
									   BM = 4,
									   AmountBC = 0,
									   AmountBM = 4,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 2,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 5,
									   AmountBC = 0,
									   AmountBM = 1,
								   }
								},
								IdPayment = 2,
								Payment = new Payment()
								{
									Id = 2,
									CardNumber = "4237 7128 1972 1149" ,
									IdOrder = 1,
									Name = "Николай",
									LastName = "Абрамов",
									Validity = "9/28",
								},
								IdDeliveryMan = 1,
								DeliveryMan = new DeliveryMan()
								{
									Name = "Василий",
									LastName = "Иванов",
									PhoneNumber = 89926562311,
									IdOrder = 1,
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "15.5.23 15:11",
								Positions = new List<Position?> ()
								{
								   new Position
								   {
									   BC = 0,
									   BM = 5,
									   AmountBC = 0,
									   AmountBM = 1,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 3,
									   AmountBC = 0,
									   AmountBM = 2,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 1,
									   AmountBC = 0,
									   AmountBM = 1,
								   },
								   new Position
								   {
									   BC = 0,
									   BM = 6,
									   AmountBC = 0,
									   AmountBM = 1,
								   }
								},
							},
							new Order
							{
								Id = 2,
								IsActive = 0,
								Date = "14.12.22 11:11",
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
						},
					}
				};
            }
        }
	}
}