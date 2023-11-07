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

    public Guid Create(UserCreateDTO userCreateDTO)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserDTO> GetById()
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(UserUpdateDTO userUpdateDTO)
    {
        throw new NotImplementedException();
    }
}
