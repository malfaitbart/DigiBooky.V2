using DigiBooky.V2.Db;
using DigiBooky.V2.Domain.Authors;
using DigiBooky.V2.Domain.Books;
using DigiBooky.V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DigiBooky.V2.Serices.Tests.BookServices
{
	public class BookServiceTest
	{
		[Fact]
		public void GivenABookServiceAndABook_WhenAddBook_ThenBookIsAddedToBookDatabase()
		{
			//Given
			BookService bookService = new BookService();
			Book book = new Book("1234567891235", "title", Guid.NewGuid());

			//When
			bookService.AddBook(book);

			//Then
			var actual = DB_Book.Books.First(bookSelection => bookSelection.ISBN == book.ISBN);
			Assert.Equal(book, actual);
		}

		[Fact]
		public void GivenABookServiceAndABookDB_WhenGetAll_ThenGetAListOfBooks()
		{
			//Given
			BookService bookService = new BookService();

			//When
			var actual = bookService.GetAll();

			//Then
			Assert.IsType<List<Book>>(actual);
		}

		[Fact]
		public void GivenABookServiceAndABookDB_WhenGetByISBN_ThenGetBook()
		{
			//Given
			BookService bookService = new BookService();
			Book book = new Book("1234567891234", "title", Guid.NewGuid());
			DB_Book.Books.Add(book);
			//When
			var actual = bookService.GetByISBN("1234567891234");

			//Then
			Assert.Equal(book, actual);
		}

	}
}
