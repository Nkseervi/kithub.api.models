using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.PhonePe
{
    public class CheckStatusResponse
    {
        public bool success { get; set; }
        public string code { get; set; }
        public string message { get; set; }
        public CheckStatusResponseData data { get; set; }
    }
}
