using System;
using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    class AccountRepository : IAccountRepository
    {
        public IEnumerable<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }
    }
}