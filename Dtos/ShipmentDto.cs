using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class ShipmentDto
    {
        public int Id { get; set; }
        public string TrackingId { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public decimal Amount { get; set; }
        public string? Gateway { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public string? Callback { get; set; }
        public string? CheckstatusRequest { get; set; }
        public string? CheckstatusResponse { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
