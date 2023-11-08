using picpay_desafio.DTO;

namespace picpay_desafio.Interface.Services
{
    public interface ITransactionService
    {
        public Task<List<TransactionDTO>> GetByUserId(Guid id);
        public Task<Guid> Create(Guid PayerId, TransferDTO transferDTO);
    }
}
