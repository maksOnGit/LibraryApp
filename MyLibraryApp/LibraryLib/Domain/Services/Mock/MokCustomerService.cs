using LibraryLib.Data;
using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    public class MokCustomerService : ICustomers
    {
        public bool CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool CreateCustomer(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            return MockDataSeeder.Customers;
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
