using picpay_desafio.Enums;

namespace picpay_desafio.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Wallet {  get; set; }
        public string Document { get; set; }
        public UserType Type { get; set; }
        public bool Active { get; set; }

            
    }
}
