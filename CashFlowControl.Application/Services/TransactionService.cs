using CashFlowControl.Core.Entities;
using CashFlowControl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CashFlowControl.Application.Services
{
    public class TransactionService
    {
        private readonly CashFlowContext _context;

        public TransactionService(CashFlowContext context)
        {
            _context = context;
        }

        public async Task AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }
    }
}
