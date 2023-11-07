using picpay_desafio.DTO;
using picpay_desafio.Models;

namespace picpay_desafio.Interface.Repositories
{
    public interface IUserRepository
    {
        public Task<List<UserDTO>> GetAll();
        public Task<UserDTO> GetById();
        public void UpdateUser(UserUpdateDTO userUpdateDTO);
        public Guid Create(UserCreateDTO userCreateDTO);
        public Task DeleteUser(Guid id);

    }
}
