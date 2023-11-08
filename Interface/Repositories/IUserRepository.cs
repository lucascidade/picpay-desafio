using picpay_desafio.DTO;
using picpay_desafio.Models;

namespace picpay_desafio.Interface.Repositories
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAll();
        public Task<User?> GetById(Guid id);
        public void UpdateUser(User user);
        public Guid Create(User user);
        public void DeleteUser(User user);
        public Task<bool> Exists(User user);

    }
}
