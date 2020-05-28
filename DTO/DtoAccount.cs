using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DtoAccount
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public DtoAccount()
		{
		}

		public DtoAccount(string username, string password)
		{
			Username = username;
			Password = password;
		}
	}
}