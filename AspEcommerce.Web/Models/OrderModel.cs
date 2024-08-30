using AspEcommerce.Core.Domain.Sale;
using AspEcommerce.Web.Models.ManageViewModels;

namespace AspEcommerce.Web.Models
{
    public class OrderModel
    {
        public Guid UserId { get; set; }
        public string? OrderNumber { get; set; }
        public Guid BillingAddressId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderPlacedDateTime { get; set; }
        public DateTime OrderCompletedDateTime { get; set; }
        public decimal TotalOrderPrice { get; set; }

        public BillingAddressModel? BillingAdddress { get; set; }
        public List<OrderItem>? Items { get; set; }
    }
}
