using DigiBooky.V2.Db;
using DigiBooky.V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DigiBooky.V2.Serices.Tests.LendingServices
{
	public class LendingServiceTest
	{
		[Fact]
		public void GivenABookDBAndAUserDBWithALendingService_WhenLendBook_ThenAddInfoToLendingDB()
		{
			//Given
			LendingService lendingService = new LendingService();

			//When
			var actualbool = lendingService.LendBook("1111111111111", "123456");
			var actualData = DB_Lending.Lendings.FirstOrDefault(lend => lend.INSS == "1111111111111");
			//Then
			Assert.True(actualbool);
			Assert.Equal("1111111111111", actualData.INSS);
		}


	}
}