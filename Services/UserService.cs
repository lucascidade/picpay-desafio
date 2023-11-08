using AutoMapper;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Interface.Services;
using picpay_desafio.Models;
using System.Data;

namespace picpay_desafio.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public UserService(IUserRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;

    }
    public async Task<List<UserDTO>> GetAll()
    {
        var user = await _repository.GetAll();
        return user.Select(u => _mapper.Map<UserDTO>(u)).ToList();
    }

    public async Task<UserDTO> GetById(Guid id)
    {
        var dbuser = await  _getById(id);
        return _mapper.Map<UserDTO>(dbuser);
    }

    public async Task<Guid> Create(UserCreateDTO userCreateDTO)
    {
        //transformando o User em USERDTO
        var user =  _mapper.Map<User>(userCreateDTO);
        if(await _repository.Exists(user))
        {
            throw new Exception("Não foi possível realizar o cadastro, email ou CPF/CNPJ já informados por outro usuário!");
        }
        var newUser = _repository.Create(user);
        await _unitOfWork.Save();
        return newUser;
    }

    public async Task DeleteUser(Guid id)
    {
        var dbUser = await _getById(id);
        _repository.DeleteUser(dbUser);
        await _unitOfWork.Save();
    }

    public async Task UpdateUser(Guid id, UserUpdateDTO userUpdateDTO)
    {
        var dbUser =await _getById(id);
        _mapper.Map(userUpdateDTO, dbUser);
        _repository.UpdateUser(dbUser);
        await _unitOfWork.Save();
    }

    private async Task<User> _getById(Guid id) => await _repository.GetById(id) ?? 
        throw new Exception("Usuário não encontrado!");


}
