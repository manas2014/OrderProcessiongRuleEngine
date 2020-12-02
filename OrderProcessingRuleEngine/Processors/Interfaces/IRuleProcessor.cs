using OrderProcessingRuleEngine.Models;
using OrderProcessingRuleEngine.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine
{
    public interface IRuleProcessor<T>
    {
         IEnumerable<T> ExecuteRules(IEnumerable<T> items, IEnumerable<IRule<T>> rules);
    }
}
