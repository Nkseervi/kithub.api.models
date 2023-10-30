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
        [Required(ErrorMessage = "Email Address is required.")]
        public string  Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public  string Password { get; set; }
    }
}
