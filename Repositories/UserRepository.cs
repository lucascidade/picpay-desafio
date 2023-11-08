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
        return _context.Users.Where(u => u.Active == true).ToListAsync();
    }

    public async Task<User?> GetById(Guid id)
    {
        return await _context.Users.FindAsync(id);
    }

    public Guid Create(User user)
    {
        _context.Add(user);
        return user.Id;
    }

    public void DeleteUser(User user)
    {
        user.DisableUser();
        _context.Users.Update(user);
  
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Exists(User user)
    {
        var dbuser =  _context.Users.FirstOrDefault(us => us.Document == user.Document || us.Email == user.Email);
        return dbuser != null;
    }

}
