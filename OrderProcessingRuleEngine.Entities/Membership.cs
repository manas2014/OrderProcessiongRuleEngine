namespace OrderProcessingRuleEngine.Entities
{
    public class Membership : Product
    {
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

    }
}
