using picpay_desafio.DTO;
using picpay_desafio.Models;

namespace picpay_desafio.Interface.Repositories
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAll();
        public Task<User> GetById();
        public void UpdateUser(User user);
        public Guid Create(User user);
        public Task DeleteUser(Guid id);

    }
}
