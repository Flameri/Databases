using System;
using System.Collections.Generic;
using System.Text;
using BankDB.Models;

namespace BankDB.Repositories
{
    interface IBankRepository
    {
        List<Bank> Read();
        Bank GetBankById();
        void Create();
        void Update();
        void Delete();

    }
}
