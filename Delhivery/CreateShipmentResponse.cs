using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Delhivery
{
    public class CreateShipmentResponse
    {
        public decimal cod_amount { get; set; }
        public int cod_count { get; set; }
        public int prepaid_count { get; set; }
        public bool success { get; set; }
        public string upload_wbn { get; set; }
        public int package_count { get; set; }
        public List<CreateShipmentRespPackage> packages { get; set; }   
  
    }

    public class CreateShipmentRespPackage
    {
        public string client {  get; set; }
        public decimal cod_amount { get; set; }
        public string payment {  get; set; }
        public string refnum {  get; set; }
        public bool serviceable {  get; set; }
        public string status {  get; set; }
        public string waybill {  get; set; }
    }
}