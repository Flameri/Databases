using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDB.Repositories
{
    class AccountRepository : IAccountRepository
    {
        private readonly BankdbContext _context = new BankdbContext();
        
        //Print Accounts
        public List<Account> Read()
        {
            List<Account> accounts = _context.Account.ToListAsync().Result;
            return accounts;
        }

        //Find account by id
        public Account GetAccountById(string iban)
        {
            var account = _context.Account.FirstOrDefault(a => a.Iban == iban);
            return account;
        }

        //Create new Account
        public void CreateAccount(Account account
        {
            _context.Add(account);
            _context.SaveChanges();
        }
       
        //Delete an account
        public void DeleteAccount(string iban)
        {
            var delAccount = _context.Account.FirstOrDefault(a => a.Iban == iban);
            if (delAccount!= null)
                _context.Account.Remove(delAccount);
            _context.SaveChanges();
        }
    }
}
