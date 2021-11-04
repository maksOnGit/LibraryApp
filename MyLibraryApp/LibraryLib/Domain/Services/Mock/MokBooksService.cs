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
            MockDataSeeder.Books.Add(book);
            return MockDataSeeder.Books.Contains(book);
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            //throw new NotImplementedException();
            Book newBook = new Book
            {
                Id = GetAllBooks().Count,
                BookName = bookName,
                Publisher = publisher,
                Authors = authors,
                Categories = categories,
                IsIssued = false,
            };
            return CreateBook(newBook);
        }

        public bool CreateBook(string bookName, int publisherID, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            Publisher publisher = MockDataSeeder.Publishers.Where(p => p.ID == publisherID).FirstOrDefault();
            Book newBook = new Book
            {
                Id = GetAllBooks().Count,
                BookName = bookName,
                Publisher = publisher,
                Authors = authors,
                Categories = categories,
                IsIssued = false,
            };
            return CreateBook(newBook);
        }

        public bool DeleteBook(Book book)
        {
            if (book.IsIssued == true)
            {
                return false;
            }
            return MockDataSeeder.Books.Remove(book);
            
        }

        public bool DeleteBookById(int id)
        {
            Book book = MockDataSeeder.Books.Where(b => b.Id == id).FirstOrDefault();
            return DeleteBook(book);
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
            if (book != null)
            {
            book.IsIssued = true;
            return book.IsIssued;
            }
            return false;
        }

        public bool IssueBookById(int id)
        {
            Book book = GetAllBooks().Where(b => b.Id == id).FirstOrDefault();
            return IssueBook(book);
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
