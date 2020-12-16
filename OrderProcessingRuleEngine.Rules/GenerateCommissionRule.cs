using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;

namespace OrderProcessingRuleEngine.Rules
{
    public class GenerateCommissionRule : IRule<Order>
    {
        public Order Apply(Order obj)
        {
            foreach (var product in obj.Products)
            {

                if (product.ProductType == ProductType.Physical || product.GetType() == typeof(Book))
                {
                    obj.IsCommissionGenerated = true;

                }
            }
            return obj;
        }
    }
}
