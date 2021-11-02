using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
    public interface IBooks
    {
        //Create
        bool CreateBook(Book book);
        bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false);
        bool CreateBook(string bookName, int publisherID, List<Author> authors, List<Category> categories, bool isIssued = false);
        //Read
        List<Book> GetAllBooks();
        List<Book> GetAllAvaiableBooks();
        List<Book> GetAllIssuedBooks();
        Book GetBookById(int id);
        List<Book> GetAllBooksByCategory(Category category);
        List<Book> GetAllBooksByCategoryID(int id);
        List<Book> GetAllBooksByAuthor(Author author);
        List<Book> GetAllBooksByAuthorID(int id);
        List<Book> GetAllBooksByPublisher(Publisher publisher);
        List<Book> GetAllBooksByPublisherID(int id);

        //Update

        bool UpdateBook(Book book);
        bool IssueBook(Book book);
        bool IssueBookById(int id);
        bool ReturnBook(Book book);
        bool ReturnBookById(int id);

        //Delete
        bool DeleteBook(Book book);
        bool DeleteBookById(int id);

    }
}
