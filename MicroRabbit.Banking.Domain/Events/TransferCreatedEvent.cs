using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public Guid FromAccount { get; protected set; }
        public Guid ToAccount { get; protected set; }
        public double Amount { get; protected set; }

        public TransferCreatedEvent(Guid fromAccount, Guid toAccount, double amount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Amount = amount;
        }
    }
}