using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class PincodeDetailsDto
    {
        public string City { get; set; }
        public bool CodAvailable { get; set; }
        public string District { get; set; }
        public bool PrepaidAvailable { get; set; }
        public string State { get; set; }
        public bool IsOutOfDeliveryArea { get; set; }
    }
}
