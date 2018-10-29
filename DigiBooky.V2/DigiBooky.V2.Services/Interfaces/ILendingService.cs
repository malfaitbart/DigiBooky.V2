using DigiBooky.V2.Domain.Lendings;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Services.Interfaces
{
	public interface ILendingService
	{
		List<Lending> GetAll();
		Lending GetByID(Guid id);
		Lending GetByISBN(string isbn);
		Lending GetByINSS(string inss);
		bool LendBook(string inss, string isbn);
		string ReturnLending(Guid id);
	}
}
