
namespace picpay_desafio.Models;
public class Transaction
{
    public Transaction(Guid payerId, Guid payeeId, decimal value, Guid id = default)
    {
        PayerId = payerId;
        PayeeId = payeeId;
        Value = value;
        Date = DateTime.UtcNow;
        Id = id;

    }

    public User? Payer { get; set; }
    public User? Payee { get; set; }
    public Guid Id { get; set; }
    public Guid PayerId { get; set; }
    public Guid PayeeId { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
}
