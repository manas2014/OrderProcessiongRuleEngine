using OrderProcessingRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Rules
{
    public interface IRule<T>
    {
        void  Execute(IEnumerable<T> orders);
    }
}
