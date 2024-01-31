using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class ShipmentDto
    {
        [Required, CustomValidation(typeof(ShipmentModeValidation), nameof(ShipmentModeValidation.ValidateMode))]
        public string Mode { get; set; }
        public string Pincode { get; set; }
        public int Grams { get; set; }

        [Required, CustomValidation(typeof(PaymentMethodValidation), nameof(PaymentMethodValidation.ValidatePaymentMethod))]
        public string PaymentMethod { get; set; }
        public decimal CodAmount { get; set; }
    }

    public class ShipmentModeValidation
    {
        public static ValidationResult ValidateMode(string mode)
        {
            return (mode == "Surface" || mode == "Express")
                ? ValidationResult.Success
                : new ValidationResult("The Mode of Shipment is not valid");
        }
    }
    public class PaymentMethodValidation
    {
        public static ValidationResult ValidatePaymentMethod(string payMethod)
        {
            return (payMethod == "COD" || payMethod == "Pre-paid")
                ? ValidationResult.Success
                : new ValidationResult("The Payment method is not valid");
        }
    }
}
