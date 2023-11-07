using picpay_desafio.Interface.Repositories;
using picpay_desafio.Models;

namespace picpay_desafio.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Guid Create()
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
