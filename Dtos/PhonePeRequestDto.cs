using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class PhonePeRequestDto
    {
        public string XVerify { get; set; }
        public string Base64Payload { get; set; }
    }
}
