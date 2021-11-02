using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
    public interface ICustomers
    {
        //Create
        bool CreateCustomer(Customer customer);
        bool CreateCustomer(string firstName, string lastName);

        //Read
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        //update
        bool UpdateCustomer(Customer customer);
        //delete
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomerById(int id);

    }
}
