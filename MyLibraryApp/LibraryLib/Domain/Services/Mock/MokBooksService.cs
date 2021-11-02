using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    public class MokBooksService : IBooks
    {
        public bool CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            throw new NotImplementedException();
        }

        public bool CreateBook(string bookName, int publisherID, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBookById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllAvaiableBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByAuthorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByCategoryID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByPublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByPublisherID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllIssuedBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IssueBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool IssueBookById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool ReturnBookById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
