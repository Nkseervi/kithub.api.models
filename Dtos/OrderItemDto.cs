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
        public string ProductDescription {  get; set; } = string.Empty;
        public int GstRate { get; set; }
        public decimal ListedPrice { get; set; }
        public int DiscountPercent { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Qty { get; set; }
    }
}
