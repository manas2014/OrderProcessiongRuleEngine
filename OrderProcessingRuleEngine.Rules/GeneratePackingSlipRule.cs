using System;
using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;

namespace OrderProcessingRuleEngine.Rules
{
    public class GeneratePackingSlipRule : IRule<Order>
    {
        public Order Apply(Order obj)
        {
            foreach (var product in obj.Products)
            {
                if (product.ProductType == ProductType.Physical)
                    obj.IsPackingSlipGenerated = true;
                if (product.GetType() == typeof(Book))
                    obj.IsPackingSlipGeneratedForRoyaltyDept = true;
            }

            return obj;
        }
    }
}
