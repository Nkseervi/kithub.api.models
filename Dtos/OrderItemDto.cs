using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class OrderItemDto
    {
        public string ProductName { get; set; } = string.Empty;
        public int ListedPrice { get; set; }
        public int Discount { get; set; }
        public int SellingPrice { get; set; }
        public int Qty { get; set; }
    }
}
