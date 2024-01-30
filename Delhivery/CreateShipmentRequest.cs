using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Delhivery
{
    public class CreateShipmentRequest
    {
        public List<CreateShipmentReqShipment> shipments { get; set; }
        public CreateShipmentReqPickupLocation pickup_location { get; set; }
    }

    public class CreateShipmentReqShipment
    {
        public string name { get; set; }
        public string add { get; set; }
        public string pin { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string order { get; set; }
        public string payment_mode { get; set; }
        public string products_desc { get; set; }
        public string hsn_code { get; set; }
        public string cod_amount { get; set; }
        public string order_date { get; set; }
        public string total_amount { get; set; }
        public string seller_add { get; set; }
        public string seller_name { get; set; }
        public string seller_inv { get; set; }
        public string quantity { get; set; }
        public string shipment_width { get; set; }
        public string shipment_height { get; set; }
        public string weight { get; set; }
        public string seller_gst_tin { get; set; }
        public string shipping_mode { get; set; }

    }
    public class CreateShipmentReqPickupLocation
    {
        public string name { get; set; }
        public string add { get; set; }
        public string city { get; set; }
        public string pin_code { get; set; }
        public string country { get; set; }
        public string phone { get; set; }

    }
}
