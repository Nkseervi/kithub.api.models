using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class ShipmentDto
    {
        public string Mode { get; set; } = "Surface";
        public string Pincode { get; set; }
        public int Grams { get; set; }
        public int CoDPaymentAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
