
using System;

namespace OrderProcessingRuleEngine.Entities
{
    public abstract class Product : BaseProduct
    {
        public Guid Id { get; set; }

        public ProductType ProductType { get; set; }
    }
}
