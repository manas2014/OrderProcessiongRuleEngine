using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;

namespace OrderProcessingRuleEngine.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        readonly IList<Order> _orders;

        public OrderRepository() : base()
        {
            //MockData
            _orders = new List<Order>
            {
                new Order()
                {
                    OrderId = new Guid(),
                    Products = new List<Product>
                    {
                        new Book()
                        {
                            Id = new Guid(),
                            Name = "B1",
                            ProductType = ProductType.Physical
                        }
                    }
                },
                new Order()
                {
                    OrderId = new Guid(),
                    Products = new List<Product>
                    {
                        new Book()
                        {
                            Id = new Guid(),
                            Name = "B1",
                            ProductType = ProductType.Physical
                        },
                        new Membership()
                        {
                            Id = new Guid(),
                            MembershipType = MembershipType.New,
                            ProductType = ProductType.NotPhysical
                        }
                    }
                },
                new Order()
                {
                    OrderId = new Guid(),
                    Products = new List<Product>
                    {
                        new Book()
                        {
                            Id = new Guid(),
                            Name = "B1",
                            ProductType = ProductType.Physical
                        },
                        new Membership()
                        {
                            Id = new Guid(),
                            MembershipType = MembershipType.New,
                            ProductType = ProductType.NotPhysical
                        }
                    }
                },
                new Order()
                {
                    OrderId = new Guid(),
                    Products = new List<Product>
                    {
                        new Book()
                        {
                            Id = new Guid(),
                            Name = "B5",
                            ProductType = ProductType.NotPhysical
                        },
                        new Video()
                        {
                            Id = new Guid(),
                            Name = "Learning to Ski",
                            ProductType = ProductType.NotPhysical
                        }
                    }
                },
                new Order()
                {
                    OrderId = new Guid(),
                    Products = new List<Product>
                    {
                        new Book()
                        {
                            Id = new Guid(),
                            Name = "B5",
                            ProductType = ProductType.NotPhysical
                        },
                        new Membership()
                        {
                            Id = new System.Guid(),
                            MembershipType = MembershipType.Renew,
                            ProductType = ProductType.NotPhysical
                        }
                    }
                }
            };

        }

        public void Add(Order item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> FindAll()
        {
            return _orders.AsQueryable();
        }

        public IQueryable<Order> FindByCondition(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
