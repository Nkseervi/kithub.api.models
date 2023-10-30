using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
    public class AuthenticatedUserDto
    {
        public string Access_Token { get; set; }
        public string UserName { get; set;}
    }
}
