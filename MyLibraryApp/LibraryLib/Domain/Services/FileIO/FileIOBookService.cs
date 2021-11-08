using LibraryLib.Data;
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

        IPublishers publishersService = new FileIOPublishersService();


        //path where to store book.txt file
        string location = @"C:\\Users\\Intec\\Desktop\\LibraryApp\\Books.txt";
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
            Book newBook = new Book { Id = Helper.CalculateId(books), BookName = bookName, Publisher = publisher, Authors = authors, Categories = categories, IsIssued = false };

            return CreateBook(newBook);
        }

        public bool CreateBook(string bookName, int publisherID, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            Publisher publisher = publishersService.GetPublisherById(publisherID);
            Book newBook = new Book { Id = Helper.CalculateId(books), BookName = bookName, Publisher = publisher, Authors = authors, Categories = categories, IsIssued = false };
            return CreateBook(newBook);
        }

        public bool DeleteBook(Book book)
        {

            Book x = books.Where(b => b.Id == book.Id && b.IsIssued == false).FirstOrDefault();
            bool res = books.Remove(x);

            SaveBooks();
            return res;
            //GetAllBooks();
            //if (book.IsIssued == true)
            //{
            //    return false;
            //}
            //bool x = books.Remove(book);
            //return x;
        }

        public bool DeleteBookById(int id)
        {
            return DeleteBook(books.Where(b => b.Id == id && b.IsIssued == false).FirstOrDefault());
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
                Serializator.Serialize(location, MockDataSeeder.Books);

                return GetAllBooks();
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
            Book book = GetAllBooks().Where(b => b.Id == id).FirstOrDefault();
            return book;
        }

        public bool IssueBook(Book book)
        {
            if (book != null)
            {
                book.IsIssued = true;
                SaveBooks();
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

        private void SaveBooks()
        {
            Serializator.Serialize(location, books);
        }
    }
}
