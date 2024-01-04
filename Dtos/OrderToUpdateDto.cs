using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class OrderToUpdateDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string? Request {  get; set; }
        public string? Response { get; set; }
        public string? Callback { get; set; }
        public string? CheckStatusRequest { get; set; }
        public string? CheckStatusResponse { get; set; }
    }
}
