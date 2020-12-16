using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Contracts
{
    public interface IRepositoryWrapper
    {
        IOrderRepository Orders { get; }
        void Save();
    }
}
