using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using LibraryLib.Domain.Services.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppTests
{
    [TestClass]

    public class TestMockBookService
    {
        [TestMethod]
        public void Get_All_Books_Test()
        {
            //arrange
            IBooks booksService = new MokBooksService();

            //act

            List<Book> books = booksService.GetAllBooks();

            //assert
            Assert.IsNotNull(books);
        }

        [TestMethod]
        public void Get_Book_By_Id()
        {
            //arrange
            IBooks booksService = new MokBooksService();

            //act
            Book book = booksService.GetBookById(0);

            // assert
            Assert.IsNotNull(book);
            Assert.IsTrue(book.BookName == "Hamlet");
        }
    }
}
