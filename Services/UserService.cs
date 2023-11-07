using AutoMapper;
using picpay_desafio.DTO;
using picpay_desafio.Interface.Repositories;
using picpay_desafio.Interface.Services;
using picpay_desafio.Models;

namespace picpay_desafio.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

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

        public Guid Create(UserCreateDTO userCreateDTO)
        {
            throw new NotImplementedException();
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
}
