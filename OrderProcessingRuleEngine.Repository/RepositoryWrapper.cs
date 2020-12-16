using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingRuleEngine.Contracts;

namespace OrderProcessingRuleEngine.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IOrderRepository _order;
        public IOrderRepository Orders
        {
            get
            {
                if (_order == null)
                {
                   // _order = new OrderRepository(_repoContext);
                   _order = new OrderRepository();
                }
                return _order;
            }
        }
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public RepositoryWrapper()
        {
        }

        public void Save()
        {
          //  _repoContext.SaveChanges();
        }
    }
}

