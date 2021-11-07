using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using LibraryLib.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.FileIO
{
    public class FileIOBookService : IBooks
    {
        //path where to store book.txt file
        string location = @"C:\Users\User\Documents\GIT\LibraryLinQ\LibraryApp\Books.txt";
        private List<Book> books = new List<Book>();

        public bool CreateBook(Book book)
        {
            GetAllBooks();
            books.Add(book);
            SaveBooks();
            return books.Contains(book);
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            GetAllBooks();
            Book newBook = new Book { Id = books.Count, BookName = bookName, Publisher = publisher, Authors = authors, Categories = categories, IsIssued = false };

            return CreateBook(newBook);
        }

        public bool CreateBook(string bookName, int publisherID, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(Book book)
        {
            Book x = books.Where(b => b.Id == book.Id).FirstOrDefault();
            bool res = books.Remove(x);

            SaveBooks();
            return res;
        }

        public bool DeleteBookById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllAvaiableBooks()
        {
            return GetAllBooks().Where(b => b.IsIssued == false).ToList();
        }

        public List<Book> GetAllBooks()
        {
            if (File.Exists(location))
            {
                books = Serializator.Deserialize<List<Book>>(location);
                return books;
            }
            else
            {
                Serializator.Serialize(location, new List<Book>());
                return new List<Book>();
            }
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

        private void SaveBooks()
        {
            Serializator.Serialize(location, books);
        }
    }
}
