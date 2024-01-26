using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Type { get; set; }
        public string Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        [Required, DataType(DataType.PostalCode), Length(6,6)]
        public string PinCode { get; set; }
        public string? Landmark { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        public string? Instructions { get; set; }
        public bool SetAsDefault { get; set; }
    }
}
