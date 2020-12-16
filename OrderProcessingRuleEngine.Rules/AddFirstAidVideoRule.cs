using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;

namespace OrderProcessingRuleEngine.Rules
{
    public class AddFirstAidVideoRule : IRule<Order>
    {
        public Order Apply(Order obj)
        {
            return obj;
        }
    }
}
