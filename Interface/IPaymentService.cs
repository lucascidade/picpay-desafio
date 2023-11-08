namespace picpay_desafio.Interface
{
    public interface IPaymentService
    {

        public Task<bool> Validate();
    }
}
