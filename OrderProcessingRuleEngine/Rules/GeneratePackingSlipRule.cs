using OrderProcessingRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProcessingRuleEngine.Rules
{
    public class GeneratePackingSlipRule : IRule<Order>
    {
        public void Execute(IEnumerable<Order> orders)
        {

            var products = orders.SelectMany(x => x.Products);
            foreach(var product in products)
            {

                if(product.ProductType == ProductType.Physical)
                {
                    //Returning a string value for demo purpose only
                    Console.WriteLine("Packing Slip Generated");
                   
                }
                if(product.GetType() == typeof(Book))
                {
                    //Returning a string value for demo purpose only
                    Console.WriteLine("Duplicate Packing Slip Generated");
                }
                
            }
        }
    }
}
