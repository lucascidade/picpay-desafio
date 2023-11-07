using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using picpay_desafio.Data;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Models;

namespace picpay_desafio.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PicpayDataContext _context;

    public UserRepository(PicpayDataContext context) {
        _context = context;

    }

    public Task<List<User>> GetAll()
    {
        return _context.Users.Where(u => u.Active).ToListAsync();
    }

    public Task<User> GetById()
    {
        throw new NotImplementedException();
    }

    public Guid Create(User user)
    {
        _context.Add(user);
        return user.Id;
    }

    public Task DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }



    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
