using DigiBooky.V2.Domain.Authors;
using DigiBooky.V2.Domain.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Services.Interfaces
{
	public interface IBookService
	{
		List<Book> GetAll();
		Book GetByISBN(string isbn);
		Book GetByTitle(string title);
		Book GetByAuthor(Author author);

	}
}
