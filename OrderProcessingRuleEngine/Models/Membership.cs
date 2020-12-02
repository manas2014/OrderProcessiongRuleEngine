using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Models
{
    public class Membership : Product<int>
    {
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public void ActivateMembership()
        {

        }
        public void RenewMembership()
        {

        }
        public void Notify()
        {

        }
    }
}
