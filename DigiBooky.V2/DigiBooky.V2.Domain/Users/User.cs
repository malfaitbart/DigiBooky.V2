using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Domain.Users
{
	public class User
	{
		public enum UserRole { Member, Librarian, Admin}
		public Guid ID { get; private set; }
		public string INSS { get; private set; }
		public string LastName { get; private set; }
		public string FirstName { get; private set; }
		public string Email { get; private set; }
		public UserRole Role { get; private set; }
		public string Street { get; private set; }
		public string Number { get; private set; }
		public string PostalCode { get; private set; }
		public string City { get; private set; }

		public User(string iNSS, string lastName, string firstName, string email, string street, string number, string postalCode, string city)
		{
			ID = Guid.NewGuid();
			INSS = iNSS;
			LastName = lastName;
			FirstName = firstName;
			Email = email;
			Role = UserRole.Member;
			Street = street;
			Number = number;
			PostalCode = postalCode;
			City = city;
		}
	}
}
