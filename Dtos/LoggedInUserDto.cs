using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kithub.api.models.Dtos
{
	public class LoggedInUserDto
	{
		public string Token { get; set; }
		public string Id { get; set; } = "default";
        public int CartId { get; set; }
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public DateTime CreateDate { get; set; }
		public void ResetUserModel()
		{
			Token = string.Empty;
			Id = "default";
			FirstName = string.Empty;
			LastName = string.Empty;
			EmailAddress = string.Empty;
			CreateDate = DateTime.MinValue;
		}
	}
}
