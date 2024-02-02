using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Delhivery
{
    public class PincodesResponse
    {
        public List<PincodesResponseDeliveryCode>? delivery_codes { get; set; }
    }

    public class PincodesResponseDeliveryCode
    {
        public PincodesResponsePostalCode? postal_code { get; set; }
    }
    public class PincodesResponsePostalCode
    {
        public string? city { get; set; }
        public string? cod { get; set; }
        public string? district { get; set; }
        public string? pre_paid { get; set; }
        public string? cash { get; set; }
        public string? pickup { get; set; }
        public string? state_code { get; set; }
        public string? is_oda { get; set; }
    }

}
