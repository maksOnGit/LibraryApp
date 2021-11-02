using LibraryLib.Data;
using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //Optie 1
            //List<Book> availableBooks = new List<Book>();
            //foreach (var book in MockDataSeeder.Books)
            //{
            //    if (book.IsIssued)
            //    {
            //        availableBooks.Add(book);
            //    }
            //}
            //return availableBooks;

            //Optie 2 Linq
            return MockDataSeeder.Books.Where(b => b.IsIssued == false).ToList();
        }


        public List<Book> GetAllBooks()
        {
            return MockDataSeeder.Books;
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
