using DigiBooky.V2.Domain.Users;
using System.Collections.Generic;

namespace DigiBooky.V2.Db
{
	public static class DB_User
	{
		public static List<User> Users = new List<User>()
		{
			new User("1111111111111", "malfait", "bart", "malfaitbart@gmail.com", "straat", "nummer", "8550", "zwevegem")
		};
	}
}
