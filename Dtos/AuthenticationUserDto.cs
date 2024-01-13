using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class AuthenticationUserDto
    {
		//[Required(ErrorMessage = "Email Address is required.")]
		[Required(ErrorMessage = "Please enter a valid mobile number")]
		[DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid mobile number")]
		[Length(10, 10, ErrorMessage = "Please enter a valid mobile number")]
		public string Email { get; set; }
		//[Required(ErrorMessage = "Password is required.")]
		public string Password { get; set; }
	}
}
