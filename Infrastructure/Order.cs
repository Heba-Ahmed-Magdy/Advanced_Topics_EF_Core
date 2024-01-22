namespace Infrastructure
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}