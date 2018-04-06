using System;
using System.Collections.Generic;
using System.Text;
using BankDB.Models;

namespace BankDB.Repositories
{
    interface IAccountRepository
    {
        List<Account> Read();
        Account GetAccountById();
        void CreateAccount();
        void UpdateAccount();
        void DeleteAccount();
    }
}
