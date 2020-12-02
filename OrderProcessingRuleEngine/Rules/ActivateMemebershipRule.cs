using OrderProcessingRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Rules
{
   public class ActivateMemebershipRule : IRule<Order>
    {
        public void Execute(IEnumerable<Order> orders)
        {
            // Method intentionally left empty.
        }
    }
}
