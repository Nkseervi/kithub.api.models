using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public decimal OrderAmount { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
        public List<OrderItemDto> OrderItems { get; set; } = new();
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal PaymentAmount { get; set; }
        public string TrackingId { get; set; } = string.Empty;
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public string ShipmentStatus { get; set; } = string.Empty;
        public decimal ShippingAmount { get; set; }
    }
}
