using Microsoft.EntityFrameworkCore;
using picpay_desafio.Data;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Models;

namespace picpay_desafio.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly PicpayDataContext _context;
        public TransactionRepository(PicpayDataContext context) 
        {
        _context = context;
        }

        public async Task<Guid> Create(Transaction transaction)
        {
            var transactionId = await _context.AddAsync(transaction);
            return transaction.Id;
        }

        public async Task<List<Transaction>> GetByUserId(Guid id)
        {
            return await _context.Transactions
                 .Include(t => t.Payer)
                 .Include(t => t.Payee)
                 .Where(t => t.PayeeId == id || t.PayerId == id)
                 .ToListAsync();

        }
    }
}
