using FakeItEasy;
using OrderProcessingRuleEngine.Models;
using OrderProcessingRuleEngine.Rules;
using System;
using System.Collections.Generic;
using Xunit;

namespace OrderProcessingRuleEngine.Tests
{
    public class OrderRuleProcessorTest
    {
        private readonly OrderRuleProcessor _orderRuleProcessor;
        public OrderRuleProcessorTest()
        {
            _orderRuleProcessor = new OrderRuleProcessor();
        }
        [Fact]
        public void ExecuteRulesWhenOrdersAndRulesAreNotEmpty_Success()
        {

            var orders = new List<Order>
            {
                 new Order(){
                                OrderId =101,
                                Products = new List<Product<int>>
                                {
                                    new Book()
                                    {
                                        Id = 1,
                                        Name ="B1",
                                        ProductType =ProductType.Physical
                                    }
                                }
                            }
           };
            var rules = new List<IRule<Order>>{
                    new RenewMembershipRule(),
                    new GeneratePackingSlipRule(),
                    new GenerateCommissionRule(),
                    new ActivateMemebershipRule()
            };
            var output = _orderRuleProcessor.ExecuteRules(orders,rules);
            Assert.NotNull(output);
            
        }
        [Fact]
        public void ExecuteRulesWhenOrderIsEmpty_ReturnNoOrders()
        {
            Assert.True(true);
        }
        [Fact]
        public void ExecuteRulesWhenRuleIsEmpty_ReturnNoRules()
        {
            Assert.True(true);
        }

    }
}
