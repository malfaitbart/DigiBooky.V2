using DigiBooky.V2.Domain.Authors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBooky.V2.Services.Interfaces
{
	public interface IAuthorService
	{
		List<Author> GetAll();
		Author GetByID(Guid id);
	}
}
