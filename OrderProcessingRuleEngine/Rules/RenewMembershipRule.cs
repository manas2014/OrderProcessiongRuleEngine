﻿using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingRuleEngine.Models;

namespace OrderProcessingRuleEngine.Rules
{
    public class RenewMembershipRule : IRule<Order>
    {
        public void Execute(IEnumerable<Order> orders)
        {
            // Method intentionally left empty.
        }
    }
}
