using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Models
{
    public class Book : Product<int>
    {
        public string Name { get; set; }
        public decimal Price { get ; set; }
        public decimal Qty { get; set; }

        public void GenerateShippingSlip()
        {
            Console.WriteLine("Generate a Slip for Book {0}", Name);
        }
        public void GenerateCommission()
        {
            Console.WriteLine("Generate a Slip for Book {0}", Name);
        }
    }
}
