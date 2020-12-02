using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Models
{
    public abstract class Product<T> : BaseProduct
    {
        public virtual T Id { get; set; }

        public ProductType ProductType { get; set; }
    }
}
