using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.PhonePe
{
    public class PayApiResponseData
    {
        public string merchantId { get; set; }
        public string merchantTransactionId { get; set; }
        public PayApiResponseDataInstrumentResponse instrumentResponse { get; set; }
    }
}
