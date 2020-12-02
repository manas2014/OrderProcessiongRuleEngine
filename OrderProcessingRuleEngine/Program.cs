using OrderProcessingRuleEngine.Repository;
using System;

namespace OrderProcessingRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note :"GeneratePackingSlipRule" Rule is only implemented partially
            //BaseProduct -> Product<T>->Book,MemberShip,Video
           
            var orderRuleProcessor = new OrderRuleProcessor();
            var orders = new OrderRepository().GetAll();
            var rules = new RuleRepository().GetAll();
            orderRuleProcessor.ExecuteRules(orders, rules);

            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }
}
