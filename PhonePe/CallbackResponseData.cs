using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.PhonePe
{
    public class CallbackResponseData
    {
        public string merchantId { get; set; }
        public string merchantTransactionId { get; set; }
        public string transactionId { get; set; }
        public int amount { get; set; }
        public string state { get; set; }
        public string responseCode { get; set; }
        public Dictionary<string, string> paymentInstrument { get; set; }
    }
}
