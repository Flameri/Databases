﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BankDB.Models;
using System.Linq;

namespace BankDB.Repositories
{
    class CustomerRepository : ICustomerRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        //Print Customers
        public List<Customer> Read()
        {
            List<Customer> customers = _context.Customer.ToListAsync().Result;
            return customers;
        }

        //Etsi tietty asiakas
        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customer.FirstOrDefault(p => p.Id == id);
            return customer;
        }

        //Create a new customer
        public void CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }



        //Update customer info
        public void UpdateCustomer(Customer customer, int id)
        {
            var updateCustomer = GetCustomerById(id);
            if (updateCustomer != null)
            {
                updateCustomer.FirstName = customer.FirstName;
                updateCustomer.LastName = customer.LastName;
                _context.Customer.Update(customer);
            }
            _context.SaveChanges();
        }

        //Delete customer
        public void DeleteCustomer(int id)
        {
            var delCustomer = _context.Customer.FirstOrDefault(p => p.Id == id);
            if (delCustomer != null)
                _context.Customer.Remove(delCustomer);
            _context.SaveChanges();
        }

        //Account 

        //Create new Account
        public void CreateAccount(Account account
        {
            _context.Add(account);
            _context.SaveChanges();
        }


        public Account GetAccountById()
        {
            throw new NotImplementedException();
        }



        public void UpdateAccount()
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount()
        {
            throw new NotImplementedException();
        }


    }
}