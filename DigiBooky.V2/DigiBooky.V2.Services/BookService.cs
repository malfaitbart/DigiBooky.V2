using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiBooky.V2.Db;
using DigiBooky.V2.Domain.Books;

namespace DigiBooky.V2.Services
{
	public class BookService
	{
		public void AddBook(Book book)
		{
			DB_Book.Books.Add(book);
		}

		public List<Book> GetAll()
		{
			return DB_Book.Books;
		}

		public Book GetByISBN(string isbn)
		{
			return DB_Book.Books.First(book => book.ISBN == isbn);
		}
	}
}
