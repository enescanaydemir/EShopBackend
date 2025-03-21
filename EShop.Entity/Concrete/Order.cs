using EShop.Entity.Abstract;
using EShop.Shared.ComplexTypes;

namespace EShop.Entity.Concrete
{
    public class Order : BaseEntity
    {
        private Order()
        {
        }
        public Order(string? applicationUserId, string? address, string? city)
        {
            ApplicationUserId = applicationUserId;
            Address = address;
            City = city;
        }
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
