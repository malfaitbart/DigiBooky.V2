using DigiBooky.V2.Domain.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Db
{
	public static class DB_Book
	{
		public static List<Book> Books = new List<Book>()
		{
			new Book("123456", "title", DB_Author.Authors[0].ID)
		};
	}
}
