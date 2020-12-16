using System;

namespace OrderProcessingRuleEngine.Entities
{
    public class Book : Product
    {
        public string Name { get; set; }
        public decimal Price { get ; set; }
        public decimal Qty { get; set; }

      
    }
}
