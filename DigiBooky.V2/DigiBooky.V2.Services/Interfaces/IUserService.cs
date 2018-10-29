using DigiBooky.V2.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Services.Interfaces
{
	public interface IUserService
	{
		List<User> GetAll();
		User GetByINSS(string inss);
	}
}
