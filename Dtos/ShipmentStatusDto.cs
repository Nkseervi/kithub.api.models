using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class ShipmentStatusDto
    {
        public string? AWB { get; set; }
        public string? Destination { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public DateTime? PickUpDate { get; set; }
        public DateTime? PickedupDate { get; set; }
        public string? PickupLocation { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public string? TrackShipmentId { get; set; }
        public string? Instructions { get; set; }
        public string? RecievedBy { get; set; }
        public string? Status { get; set; }
        public string? StatusLocation { get; set; }
        public DateTime? StatusDateTime { get; set; }
    }
}
