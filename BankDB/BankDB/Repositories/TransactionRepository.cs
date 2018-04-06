using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BankDB.Models;

namespace BankDB.Repositories
{
    class TransactionRepository : ITransactionRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        //Find specific transaction
        public Transaction GetTransactionById(int id)
        {
            var transaction = _context.Account.FirstOrDefault(t => t.Id == id);
            return transaction;
        }

        //Print Transactions
        public List<Transaction> Read()
        {
            List<Transaction> transactions = _context.Transaction.ToListAsync().Result;
            return transactions;
        }

        //Creating transactions
        public void CreateTransaction(Transaction transaction)
        {
            _context.Add(transaction);
            _context.SaveChanges();
        }
    }
}
