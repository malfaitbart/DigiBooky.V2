using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Domain.Books
{
	public class Book
	{
		public Guid ID { get; private set; }
		public string ISBN { get; private set; }
		public string Title { get; private set; }
		public Guid AuthorID { get; private set; }

		public Book(string iSBN, string title, Guid authorID)
		{
			ID = Guid.NewGuid();
			ISBN = iSBN;
			Title = title;
			AuthorID = authorID;
		}
	}
}
