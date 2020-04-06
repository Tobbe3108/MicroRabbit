using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        Task<IEnumerable<TransferLog>> GetTransferLogs();
        Task Add(TransferLog transferLog);
    }
}