using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BankDB.Models;
using System.Linq;

namespace BankDB.Repositories
{
    class BankRepository : IBankRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        //Tulosta Pankit
        public List<Bank> Read()
        {
            List<Bank> banks = _context.Bank.ToListAsync().Result;
            return banks;
        }

        //Etsi tietty pankki
        public Bank GetBankById(int id)
        {
            var bank = _context.Bank.FirstOrDefault(p => p.Id == id);
            return bank;
        }

        //Add Bank
        public void Create(Bank bank)
        {
            _context.Add(bank);
            _context.SaveChanges();
        }

        //Update Bank
        public void Update(Bank bank, int id)
        {
            var updateBank = GetBankById(id);
            if (updateBank != null)
            {
                updateBank.Name = bank.Name;
                updateBank.Bic = bank.Bic;
                _context.Bank.Update(bank);
            }
            _context.SaveChanges();
        }

        //Delete Bank
        public void Delete(int id)
        {
            var delBank = _context.Bank.FirstOrDefault(p => p.Id == id);
            if (delBank != null)
                _context.Bank.Remove(delBank);
            _context.SaveChanges();
        }
    }
}
