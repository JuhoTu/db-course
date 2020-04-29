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
        public BankSection Create(BankSection newBank)
        {
            throw new NotImplementedException();
        }

        public List<Bank> Read()
        {
            var banks = _bankdbContext.Bank.ToList();
            return banks;
        }

        public BankSection Update(BankSection updateBank)
        {
            throw new NotImplementedException();
        }

        public BankSection Delete(BankSection deleteBank)
        {
            throw new NotImplementedException();
        }
    }
}
