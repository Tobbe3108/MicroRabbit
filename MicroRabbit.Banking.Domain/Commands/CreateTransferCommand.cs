using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(Guid from, Guid to, decimal amount)
        {
            FromAccount = from;
            ToAccount = to;
            Amount = amount;
        }
    }
}