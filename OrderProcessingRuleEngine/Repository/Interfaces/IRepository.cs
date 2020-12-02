using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
         IList<T> GetAll();
         void Add(T item);
    }
}
