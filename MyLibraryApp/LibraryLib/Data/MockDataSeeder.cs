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
            new Author{ ID = 0, FirstName="William", LastName="Shakespeare"},
            new Author{ ID = 1, FirstName="Agatha", LastName="Christie"},
            new Author{ ID = 2, FirstName="Barbara", LastName="Cartland"},
            new Author{ ID = 3, FirstName="Danielle", LastName="Steel"},
        };

        public static List<Publisher> Publishers = new List<Publisher>()
        {
            new Publisher{ID = 0, PublisherName="Hachette"},
            new Publisher{ID = 1, PublisherName="HarperCollins"},
            new Publisher{ID = 2, PublisherName="Macmillian"},
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
            new Customer{ID = 0, FirstName="Quinten", LastName="De Clerck"},
            new Customer{ID = 1, FirstName="Joe", LastName="Doe"},
            new Customer{ID = 2, FirstName="Bob", LastName="Smith"},
            new Customer{ID = 3, FirstName="Jan", LastName="Jansen"},
        };

    }
}
