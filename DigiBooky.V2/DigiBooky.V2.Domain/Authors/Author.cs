using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Domain.Authors
{
	public class Author
	{
		public Guid ID { get; private set; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		
		public Author(string firstName, string lastName)
		{
			ID = Guid.NewGuid();
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
