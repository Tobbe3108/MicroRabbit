using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _dbContext;

        public TransferRepository(TransferDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return await _dbContext.TransferLogs.ToListAsync();
        }

        public async Task Add(TransferLog transferLog)
        {
            await _dbContext.TransferLogs.AddAsync(transferLog);
            await _dbContext.SaveChangesAsync();
        }
    }
}