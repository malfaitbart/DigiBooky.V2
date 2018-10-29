using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Domain.Lendings
{
	public class Lending
	{
		public Guid ID { get; private set; }
		public string INSS { get; private set; }
		public string ISBN { get; private set; }
		public DateTime LendingDate { get; private set; }
		public DateTime ReturnDate { get; private set; }
		public bool IsBookReturned { get; private set; }

		public Lending(string iNSS, string iSBN)
		{
			ID = Guid.NewGuid();
			INSS = iNSS;
			ISBN = iSBN;
			LendingDate = DateTime.Now.Date;
			ReturnDate = DateTime.Now.Date.AddDays(21);
			IsBookReturned = false;
		}
	}
}
