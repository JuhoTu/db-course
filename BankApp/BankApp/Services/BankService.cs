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
        public Bank Create(Bank newBank)
        {
            var createBank = _bankRepository.Create(newBank);
            return createBank;
        }

        public List<Bank> Read()
        {
            var banks = _bankRepository.Read();
            return banks;
        }

        public Bank Update(Bank updateBank)
        {
            var bank = _bankRepository.Update(updateBank);
            return updateBank;
        }

        public Bank Delete(Bank deleteBank)
        {
            _bankRepository.Delete(deleteBank);
            return deleteBank;
        }
    }
}
