using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int OrderAmount { get; set; }
        public IList<Product<int>> Products { get; set; }
    }
}
