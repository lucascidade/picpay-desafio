using picpay_desafio.Data;
using picpay_desafio.Interface.Repositories;

namespace picpay_desafio.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly PicpayDataContext _context;
    public UnitOfWork(PicpayDataContext context)
    {
        _context = context;
    }
    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
