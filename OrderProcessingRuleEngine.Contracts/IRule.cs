using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Contracts
{
    public interface IRule<T>
    {
        T Apply(T obj);
    }
}
