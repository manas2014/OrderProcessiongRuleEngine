using System;
using OrderProcessingRuleEngine.Contracts;
using OrderProcessingRuleEngine.Entities;

namespace OrderProcessingRuleEngine.Rules
{
    public class MemebershipRule : IRule<Order>
    {
        public Order Apply(Order obj)
        {
            foreach (var product in obj.Products)
            {
                var pr = product as Membership;
                if (pr !=null && pr.MembershipType == MembershipType.New)
                {
                    obj.IsMembershipActivated = true;
                }
                else if (pr != null && pr.MembershipType == MembershipType.Renew)
                {
                    obj.IsMembershipActivated = true;
                }

                SendEmailNotification();

            }

            return obj;
        }

        private void SendEmailNotification()
        {
            //Send Email Notification
        }
    }

}

