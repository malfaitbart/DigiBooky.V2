using DigiBooky.V2.Db;
using DigiBooky.V2.Domain.Users;
using DigiBooky.V2.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace DigiBooky.V2.Services
{
	public class UserService : IUserService
	{
		public List<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public User GetByINSS(string inss)
		{
			throw new NotImplementedException();
		}

		public void AddUser(User user)
		{
			DB_User.Users.Add(user);
		}
	}
}
