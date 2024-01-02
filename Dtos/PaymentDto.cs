using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public string Gateway { get; set; } = string.Empty;
        public string Mode { get; set;} = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime StatusDate { get; set; }
        public decimal Amount { get; set; }
    }
}
