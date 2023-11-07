using picpay_desafio.Models;

namespace picpay_desafio.Interface.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAll();
        public Task<User> GetById();
        public void UpdateUser();
        public Guid Create();
        public Task DeleteUser(Guid id);
    }
}
