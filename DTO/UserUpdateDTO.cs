using picpay_desafio.Enums;

namespace picpay_desafio.DTO;

public record UserUpdateDTO(
    string FirstName,
    string LastName,
    string Email,
    string Document,
    decimal Wallet,
    UserType Type
    );
