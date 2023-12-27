using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.PhonePe
{
    public class CallbackResponse
    {
        public bool success { get; set; }
        public string code { get; set; }
        public string message { get; set; }
        public CallbackResponseData data { get; set; }
    }
}
