using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using BankApp.Repository;

namespace BankApp.Services
{
    class BankService : IBankService
    {
        //Inject
        private readonly IBankRepository _bankRepository = new BankRepository();
        public BankSection Create(BankSection newBank)
        {
            throw new NotImplementedException();
        }

        public List<Bank> Read()
        {
            var banks = _bankRepository.Read();
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
