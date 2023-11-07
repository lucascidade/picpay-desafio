using AutoMapper;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Interface.Services;
using picpay_desafio.Models;

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

    public Task<UserDTO> GetById()
    {
        throw new NotImplementedException();
    }

    public async Task<Guid> Create(UserCreateDTO userCreateDTO)
    {
        //transformando o User em USERDTO
        var user = _repository.Create(_mapper.Map<User>(userCreateDTO));
         await _unitOfWork.Save();
        return user;
    }

    public Task DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(UserUpdateDTO userUpdateDTO)
    {
        throw new NotImplementedException();
    }
}
