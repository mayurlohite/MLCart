using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspEcommerce.Core.Domain.Sale
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Complete,
        Cancelled
    };

    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? OrderNumber { get; set; }
        public Guid UserId { get; set; }
        public Guid BillingAddressId { get; set; }
        public decimal TotalOrderPrice { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderPlacementDateTime { get; set; }
        public DateTime? OrderCompletedDateTime { get; set; }

        public virtual ICollection<OrderItem>? Items { get; set; }
    }
}
