using OrderProcessingRuleEngine.Models;
using OrderProcessingRuleEngine.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ProductType = OrderProcessingRuleEngine.Models.ProductType;

namespace OrderProcessingRuleEngine.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        IList<Order> orders;
        public OrderRepository()
        {
            orders = new List<Order>
            {
             new Order(){
                            OrderId =101,
                            Products = new List<Product<int>>
                            {
                                new Book()
                                {
                                    Id = 1,
                                    Name ="B1",
                                    ProductType =ProductType.Physical
                                }
                            }
                        },
             new Order(){
                            OrderId =102,
                            Products = new List<Product<int>>
                            {
                                new Book()
                                {
                                    Id = 1,
                                    Name ="B1",
                                    ProductType =ProductType.Physical
                                },
                                new Membership(){
                                     Id = 1,
                                     MembershipType = MembershipType.New,
                                     ProductType =ProductType.Softcopy
                            }
                            }
                        },
             new Order(){
                     OrderId =103,
                     Products = new List<Product<int>>
                                {
                                    new Book()
                                    {
                                        Id = 1,
                                        Name ="B1",
                                        ProductType =ProductType.Physical
                                    },
                                    new Membership(){
                                         Id = 1,
                                         MembershipType = MembershipType.New,
                                         ProductType =ProductType.Softcopy
                                }
                                }
                    },
             new Order(){
                        OrderId =104,
                        Products = new List<Product<int>>
                            {
                                new Book()
                                {
                                    Id = 5,
                                    Name ="B5",
                                    ProductType =ProductType.Softcopy
                                },
                                new Video(){
                                     Id = 1,
                                     Name = "Learning to Ski",
                                     ProductType =ProductType.Softcopy
                            }
                            }
             },
             new Order(){
                        OrderId =105,
                        Products = new List<Product<int>>
                            {
                                new Book()
                                {
                                    Id = 5,
                                    Name ="B5",
                                    ProductType =ProductType.Softcopy
                                },
                                new Membership(){
                                     Id = 1001,
                                     MembershipType = MembershipType.Renew,
                                     ProductType =ProductType.Softcopy
                            }
                            } }
            };

        }
        public IList<Order> GetAll()
        {
            return orders;
        }
        public void Add(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
