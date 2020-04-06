using System;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public Guid FromAccount { get; protected set; }
        public Guid ToAccount { get; protected set; }
        public decimal Amount { get; protected set; }

        public TransferCreatedEvent(Guid fromAccount, Guid toAccount, decimal amount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Amount = amount;
        }
    }
}