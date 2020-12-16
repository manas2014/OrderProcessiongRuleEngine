using System.Collections.Generic;
using OrderProcessingRuleEngine.Contracts;

namespace OrderProcessingRuleEngine
{
    public static class RuleEngine 
    {
        public static T ApplyRule<T>(this T obj,IEnumerable<IRule<T>> rules)
        {
           foreach(var rule in rules)
           {
               rule.Apply(obj);
           }
           return obj;
        }

       
    }
}
