using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Data
{
    public class MockDataSeeder
    {
        public static List<Author> Authors = new List<Author>
        {
            new Author{ Id = 0, FirstName="William", LastName="Shakespeare"},
            new Author{ Id = 1, FirstName="Agatha", LastName="Christie"},
            new Author{ Id = 2, FirstName="Barbara", LastName="Cartland"},
            new Author{ Id = 3, FirstName="Danielle", LastName="Steel"},
        };

        public static List<Publisher> Publishers = new List<Publisher>()
        {
            new Publisher{Id = 0, PublisherName="Hachette"},
            new Publisher{Id = 1, PublisherName="HarperCollins"},
            new Publisher{Id = 2, PublisherName="Macmillian"},
        };

        public static List<Category> Categories = new List<Category>()
        {
            new Category{Id = 0, CategoryName="Horror"},
            new Category{Id = 1, CategoryName="Fiction"},
            new Category{Id = 2, CategoryName="Action"},
            new Category{Id = 3, CategoryName="Fantasy"},
        };

        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer{Id = 0, FirstName="Quinten", LastName="De Clerck"},
            new Customer{Id = 1, FirstName="Joe", LastName="Doe"},
            new Customer{Id = 2, FirstName="Bob", LastName="Smith"},
            new Customer{Id = 3, FirstName="Jan", LastName="Jansen"},
        };

        public static List<Book> Books = new List<Book>()
        {
            new Book{Id = 0, BookName="Hamlet", Publisher=Publishers.ElementAt(0), Authors = new List<Author>{Authors.ElementAt(0)}, Categories = new List<Category>(){Categories.ElementAt(1)}, IsIssued = false},
            new Book
            {
                Id = 1,
                BookName = "Murder in the orient Express",
                Publisher = Publishers.ElementAt(2),
                Authors = new List<Author>(){Authors.ElementAt(1), Authors.ElementAt(3)},
                Categories = new List<Category>(){Categories.ElementAt(0), Categories.ElementAt(1)},
                IsIssued = true,
            }
        };
    }
}
