using DigiBooky.V2.Domain.Authors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Db
{
	public static class DB_Author
	{
		public static List<Author> Authors = new List<Author>()
		{
			new Author("jan", "jansens")
		};
	}
}
