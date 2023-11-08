using picpay_desafio.DTO;
using picpay_desafio.Models;

namespace picpay_desafio.Interface.Services
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetAll();
        public Task<UserDTO> GetById(Guid id);
        public Task UpdateUser(Guid id, UserUpdateDTO userUpdateDTO);
        public Task DeleteUser(Guid id);
        public Task <Guid> Create(UserCreateDTO userCreateDTO);
        public Task<Guid> Transfer(Guid payerId, TransferDTO transferDTO);

    }
}
