using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.PhonePe
{
    public class PayApiResponseDataInstrumentResponse
    {
        public string type { get; set; }
        public PayApiResponseRedirectInfo redirectInfo { get; set; }
    }
}
