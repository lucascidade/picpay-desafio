using picpay_desafio.Enums;

namespace picpay_desafio.DTO;

public record UserCreateDTO(
        string FirstName,
        string LastName,
        string Email,
        string Document,
        decimal Wallet,
        UserType Type
    );
