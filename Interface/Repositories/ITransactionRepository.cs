using picpay_desafio.Models;

namespace picpay_desafio.Interface.Repositories;

public interface ITransactionRepository
{
    public Task<List<Transaction>> GetByUserId(Guid id);
    public Task<Guid> Create(Transaction transaction);
}
