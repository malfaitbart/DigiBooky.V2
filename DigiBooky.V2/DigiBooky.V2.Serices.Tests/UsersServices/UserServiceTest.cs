using DigiBooky.V2.Db;
using DigiBooky.V2.Domain.Users;
using DigiBooky.V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DigiBooky.V2.Serices.Tests.UsersServices
{
	public class UserServiceTest
	{
		[Fact]
		public void GivenAUserServiceAndAUserDatabase_WhenAddingAUser_ThenUserIsAddedToDb()
		{
			//Given
			UserService userService = new UserService();

			//When
			User user = new User("1234567891234", "test", "test", "malfaitbart@gmail.com", "street", "10", "8550", "zwevegem");
			userService.AddUser(user);
			var actual = DB_User.Users.First(x => x.INSS == user.INSS);
			//Then
			Assert.Equal(user, actual);
		}

		[Fact]
		public void GiveAUserServiceAndAUserDatabase_WhenAddingAUserWithoutINSS_ThenUserIsNotAddedAndErrorIsReturned()
		{
			//Given
			UserService userService = new UserService();

			//When
			User user = new User("", "test", "test", "malfaitbart@gmail.com", "street", "10", "8550", "zwevegem");

			//Then

		}
	}
}
