using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class ShippingAddressDto
    {
        //[Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        //[Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        //[Required]
        [DisplayName("Address Line 1")]
        public string ShipAddress1 { get; set; }
        [DisplayName("Address Line 2")]
        public string ShipAddress2 { get; set; }
        //[Required]
        public string City { get; set; }
        //[Required]
        public string State { get; set; }
        //[Required]
        [DisplayName("PIN Code")]
        [DataType(DataType.PostalCode)]
        public string PinCode { get; set; }
    }
}
