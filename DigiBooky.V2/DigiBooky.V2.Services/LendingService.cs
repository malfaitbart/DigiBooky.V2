using DigiBooky.V2.Db;
using DigiBooky.V2.Domain.Lendings;
using DigiBooky.V2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiBooky.V2.Services
{
	public class LendingService : ILendingService
	{
		public List<Lending> GetAll()
		{
			throw new NotImplementedException();
		}

		public Lending GetByID(Guid id)
		{
			throw new NotImplementedException();
		}

		public Lending GetByINSS(string inss)
		{
			throw new NotImplementedException();
		}

		public Lending GetByISBN(string isbn)
		{
			throw new NotImplementedException();
		}

		public bool LendBook(string inss, string isbn)
		{
			var DoesUserExist = DB_User.Users.Any(user => user.INSS == inss);
			var DoesBookExist = DB_Book.Books.Any(book => book.ISBN == isbn);
			if(DoesUserExist && DoesBookExist)
			{
				DB_Lending.Lendings.Add(new Lending(inss, isbn));
				return true;
			}
			return false;
		}

		public string ReturnLending(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
