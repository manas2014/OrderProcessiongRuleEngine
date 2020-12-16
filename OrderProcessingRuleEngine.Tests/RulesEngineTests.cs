using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;
using OrderProcessingRuleEngine.Rules;
using Xunit;
namespace OrderProcessingRuleEngine.Tests
{
    public class RulesEngineTests
    {
        [Fact]
        public void ShouldNotGeneratePackingSlip_WhenProductIsBookButNotPhysical()
        {
            // ARRANGE
            var product = new Book() { Price = 2.56m, Name = "Do Hickey" ,ProductType = ProductType.NotPhysical};

            var order1 = new Order()
            {
                OrderId = new Guid(),
                Products = new List<Product> {  product }
            };


            // ACT
            var result = order1.ApplyRule(GetRules());

            // ASSERT
            const bool expectedTotal = false;
            result.IsPackingSlipGenerated.Should().Be(expectedTotal);
            result.IsPackingSlipGeneratedForRoyaltyDept.Should().Be(true);

        }
        [Fact]
        public void ShouldGeneratePackingSlip_WhenProductIsBookAndProductTypeIsPhysical()
        {
            // ARRANGE
            var product = new Book() { Price = 2.56m, Name = "The Wing", ProductType = ProductType.Physical };

            var order1 = new Order()
            {
                OrderId = new Guid(),
                Products = new List<Product> { product }
            };


            // ACT
            var result = order1.ApplyRule(GetRules());

            // ASSERT
            const bool expectedTotal = true;
            result.IsPackingSlipGenerated.Should().Be(expectedTotal);
        }

        [Fact]
        public void ShouldNotActivateMembership_WhenProductIsBook()
        {
            // ARRANGE
            var product = new Book() { Price = 2.56m, Name = "The Wing", ProductType = ProductType.Physical };

            var order1 = new Order()
            {
                OrderId = new Guid(),
                Products = new List<Product> { product }
            };


            // ACT
            var result = order1.ApplyRule(GetRules());

            // ASSERT
            const bool expectedTotal = false;
            result.IsMembershipActivated.Should().Be(expectedTotal);
        }
        [Fact]
        public void ShouldActivateMembership_WhenProductIsMembershipAndMembershipTypeIsNew()
        {
            // ARRANGE
            var product = new Membership() { Price = 2.56m, Name = "NewsLetter", MembershipType = MembershipType.New};

            var order1 = new Order()
            {
                OrderId = new Guid(),
                Products = new List<Product> { product }
            };


            // ACT
            var result = order1.ApplyRule(GetRules());

            // ASSERT
            const bool expectedTotal = true;
            result.IsMembershipActivated.Should().Be(expectedTotal);
        }

        [Fact]
        public void ShouldGenerateCommission_WhenProductIsPhysical()
        {
            // ARRANGE
            var product = new Video() { Price = 2.56m, Name = "Video1", ProductType = ProductType.Physical};

            var order1 = new Order()
            {
                OrderId = new Guid(),
                Products = new List<Product> { product }
            };


            // ACT
            var result = order1.ApplyRule(GetRules());

            // ASSERT
            const bool expectedTotal = true;
            result.IsCommissionGenerated.Should().Be(expectedTotal);
        }
        [Fact]
        public void ShouldGenerateCommission_WhenProductIsBookAndProductTypeIsNotPhysical()
        {
            // ARRANGE
            var product = new Book() { Price = 2.56m, Name = "Book1", ProductType = ProductType.NotPhysical };

            var order1 = new Order()
            {
                OrderId = new Guid(),
                Products = new List<Product> { product }
            };


            // ACT
            var result = order1.ApplyRule(GetRules());

            // ASSERT
            const bool expectedTotal = true;
            result.IsCommissionGenerated.Should().Be(expectedTotal);
        }
        #region Private
        private static IEnumerable<IRule<Order>> GetRules()
        {
            var rules = new List<IRule<Order>>()
            {
                new MemebershipRule(),
                new GeneratePackingSlipRule(),
                new AddFirstAidVideoRule(),
                new GenerateCommissionRule()
            };
            return rules.AsEnumerable();
        }
        #endregion Private

    }
}
