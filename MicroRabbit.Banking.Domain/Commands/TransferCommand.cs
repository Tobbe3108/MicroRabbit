using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public Guid FromAccount { get; protected set; }
        public Guid ToAccount { get; protected set; }
        public double Amount { get; protected set; }
    }
}