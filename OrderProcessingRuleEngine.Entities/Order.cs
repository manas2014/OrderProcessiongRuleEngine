using System;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public IList<Product> Products { get; set; }

        public bool IsPackingSlipGenerated { get; set; }

        public bool IsPackingSlipGeneratedForRoyaltyDept { get; set; }

        public bool IsMembershipActivated { get; set; }

        public bool IsCommissionGenerated { get; set; }
    }
}
