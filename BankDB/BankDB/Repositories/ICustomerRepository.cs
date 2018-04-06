using System;
using System.Collections.Generic;
using System.Text;
using BankDB.Models;

namespace BankDB.Repositories
{
    interface ICustomerRepository
    {
        List<Customer> Read();
        Customer GetCustomerById();
        void CreateCustomer();
        void UpdateCustomer();
        void DeleteCustomer();
        
    }
}
