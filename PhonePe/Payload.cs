using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.PhonePe
{
    public class Payload
    {
        public string merchantId { get; set; }
        public string merchantTransactionId { get; set; }
        public string merchantUserId { get; set; }
        public int amount { get; set; }
        public string redirectUrl { get; set; }
        public string redirectMode { get; set; }
        public string callbackUrl { get; set; }
        public string mobileNumber { get; set; }
        public PayloadPaymentInstrument paymentInstrument { get; set; }
    }
}
