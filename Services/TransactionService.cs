﻿using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Interface.Services;

namespace picpay_desafio.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        public TransactionService(ITransactionRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Create(Guid payerId, TransferDTO transferDTO)
        {
           return await _repository.Create(new(
                payerId,
                transferDTO.PayeeId,
                transferDTO.Value
                ));
        }

        public Task<List<TransactionDTO>> GetByUserId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
