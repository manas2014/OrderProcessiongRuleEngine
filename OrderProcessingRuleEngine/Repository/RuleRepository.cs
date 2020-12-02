using OrderProcessingRuleEngine.Models;
using OrderProcessingRuleEngine.Repository.Interfaces;
using OrderProcessingRuleEngine.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Repository
{
    public class RuleRepository : IRepository<IRule<Order>>
    {
        List<IRule<Order>> rules;

        public RuleRepository(List<IRule<Order>> rules)
        {
            this.rules = rules;
        }

        public RuleRepository()
        {
            rules = new List<IRule<Order>>{
                new RenewMembershipRule(),
                new GeneratePackingSlipRule(),
                new GenerateCommissionRule(),
                new ActivateMemebershipRule()};
            
        }

        public IList<IRule<Order>> GetAll()
        {
            return rules;
        }

        public void Add(IRule<Order> item)
        {
            throw new NotImplementedException();
        }
    }
}
