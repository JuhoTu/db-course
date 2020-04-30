using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApp.Data;
using BankApp.Models;

namespace BankApp.Repository
{
    class BankRepository : IBankRepository
    {
        //Inject
        private readonly BankdbContext _bankdbContext = new BankdbContext();
        public Bank Create(Bank newBank)
        {
            try
            {
                _bankdbContext.Bank.Add(newBank);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Bank added successfully");
                return newBank;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bank creation failed" + ex.Message);
                return null;
            }
        }

        public List<Bank> Read()
        {
            var banks = _bankdbContext.Bank.ToList();
            return banks;
        }

        public Bank Update(Bank updateBank)
        {
            try
            {
                _bankdbContext.Bank.Add(updateBank);
                _bankdbContext.SaveChanges();
                Console.WriteLine("Bank updated successfully");
                return updateBank;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bank update failed" + ex.Message);
                return null;
            }
        }

        public Bank Delete(Bank deleteBank)
        {
            throw new NotImplementedException();
        }
    }
}
