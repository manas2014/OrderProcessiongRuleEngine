using OrderProcessingRuleEngine.Models;
using OrderProcessingRuleEngine.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine
{
    public class OrderRuleProcessor : IRuleProcessor<Order>
    {
        public IEnumerable<Order> ExecuteRules(IEnumerable<Order> orders, IEnumerable<IRule<Order>> rules)
        {
           foreach(var rule in rules)
            {
                rule.Execute(orders);
            }
            return orders;
        }

       
    }
}
