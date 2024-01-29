using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Delhivery
{
    public class CalcShipCostResponse
    {
        public decimal? total_amount { get; set; }
        public decimal? charged_weight { get; set;}
        public decimal? charge_COD { get; set; }
        public decimal? charge_AIR { get; set; }
        public decimal? charge_AWB { get; set; }
        public decimal? charge_DL { get; set; }
        public decimal? charge_DTO { get; set; }
        public decimal? charge_DPH { get; set; }
        public decimal? charge_RTO { get; set; }
        public decimal? charge_pickup { get; set; }
    }
}
