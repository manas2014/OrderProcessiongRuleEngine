using OrderProcessingRuleEngine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;
using OrderProcessingRuleEngine.Rules;

namespace OrderProcessingRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = GetOrders();
            var rules = GetRules();

            Parallel.ForEach(orders,
                (order) =>
                {
                    order.ApplyRule(rules);
                });
            Console.ReadLine();

        }

        private static IEnumerable<IRule<Order>> GetRules()
        {
            var rules = new List<IRule<Order>>()
            {
                new MemebershipRule(),
                new GeneratePackingSlipRule(),
                new AddFirstAidVideoRule(),
                new GenerateCommissionRule()
            };
            return rules.AsEnumerable();
        }

        private static IEnumerable<Order> GetOrders()
        {
            return new OrderRepository().FindAll();
        }
    }
}
