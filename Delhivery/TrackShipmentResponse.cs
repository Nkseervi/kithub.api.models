using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Delhivery
{
    public class TrackShipmentResponse
    {
        public List<TrackShipmentRespShipmentData> ShipmentData { get; set; }
    }

    public class TrackShipmentRespShipmentData
    {
        public TrackShipmentRespShipment Shipment { get; set; }
    }

    public class TrackShipmentRespShipment
    {
        public string? AWB { get; set; }
        public string? DeliveryDate { get; set; }
        public string? DestRecieveDate { get; set; }
        public string? Destination { get; set; }
        public string? ExpectedDeliveryDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string? FirstAttemptDate { get; set; }
        public string? OrderType { get; set; }
        public string? Origin { get; set; }
        public string? OriginRecieveDate { get; set; }
        public string? OutDestinationDate { get; set; }
        public string? PickUpDate { get; set; }
        public string? PickedupDate { get; set; }
        public string? PickupLocation { get; set; }
        public string? PromisedDeliveryDate { get; set; }
        public string? RTOStartedDate { get; set; }
        public string? ReturnedDate { get; set; }
        public string? TrackShipmentId { get; set; }
        public TrackShipmentRespShipmentStatus? Status { get; set; }
    }

    public class TrackShipmentRespShipmentStatus
    {
        public string? Instructions { get; set; }
        public string? RecievedBy { get; set; }
        public string? Status { get; set; }
        public string? StatusLocation { get; set; }
        public string? StatusDateTime { get; set; }

    }
}

