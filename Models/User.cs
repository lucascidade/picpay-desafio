using picpay_desafio.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace picpay_desafio.Models;

public class User
{
    public User (
        string firstName,
        string lastName,
        string email,
        string document,
        decimal wallet,
        UserType type,
        Guid id = default) 
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Document = document;
        Wallet = wallet;
        Type = type;
        Active = true;
        Id = id;
    }

    public Guid Id { get;  set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    [Required]
    [EmailAddress]
    public string Email { get; private set; }
    public decimal Wallet {  get; private set; }
    public string Document { get; private set; }
    public UserType Type { get; private set; }
    public bool Active { get; private set; }


    public void DisableUser() => Active = false;

}


