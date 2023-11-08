namespace picpay_desafio.DTO;

public record TransferDTO
(
    Guid PayeeId,
    decimal Value
);
