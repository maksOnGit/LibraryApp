using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using LibraryLib.Domain.Services.FileIO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryAppTests.FileIOTest
{
    [TestClass]

    public class TestFileIOBookService
    {
        [TestMethod]
        public void Create_Book_Test()
        {
            //arrange
            IBooks booksService = new FileIOBookService();

            //act
            bool booksCreated = booksService.CreateBook(new Book {});

            //assert
            Assert.IsTrue(booksCreated);
        }

        [TestMethod]
        public void Create_Book_With_Name_Test()
        {
            //arrange
            IBooks booksService = new FileIOBookService();

            //act
            bool booksCreated = booksService.CreateBook(new Book { Id= 100, BookName = "", Publisher = new Publisher(), Authors = new List<Author>(), Categories = new List<Category>(), IsIssued = false });

            //assert
            Assert.IsTrue(booksCreated);
        }

        //[TestMethod]
        //public void Create_Book_With_PublisherID_Test()
        //{
        //    //arrange
        //    IBooks booksService = new FileIOBookService();
        //    IPublishers publisherService = new FileIOPublishersService();

        //    //act
        //    Publisher publisher = publisherService.GetPublisherById(0);
        //    bool booksCreated = booksService.CreateBook(new Book { Id = 101, BookName = "", Publisher = publisher, Authors = new List<Author>(), Categories = new List<Category>(), IsIssued = false });

        //    //assert
        //    Assert.IsTrue(booksCreated);
        //}

        [TestMethod]
        public void Get_Book_By_Id()
        {
            //arrange
            IBooks booksService = new FileIOBookService();

            //act
            Book b = booksService.GetBookById(100);

            //assert
            Assert.IsNotNull(b);
        }


        [TestMethod]
        public void Get_All_Books()
        {
            //arrange
            IBooks booksService = new FileIOBookService();

            //act
            List<Book> list = booksService.GetAllBooks();

            //assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void Get_All_Avaiable_Books()
        {
            //arrange
            IBooks booksService = new FileIOBookService();

            //act
            List<Book> list = booksService.GetAllAvaiableBooks();

            //assert
            foreach (var x in list)
            {
                Assert.IsTrue(x.IsIssued == false);
            }
        }

        [TestMethod]
        public void Issue_Book()
        {
            //arrange
            IBooks booksService = new FileIOBookService();

            //act
            //List<Book> list = booksService.GetAllBooks();
            bool x = booksService.IssueBook(booksService.GetBookById(100));

            //assert
            Assert.IsTrue(booksService.GetBookById(100).IsIssued == true);
           
        }




    }
}
