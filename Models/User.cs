﻿using picpay_desafio.Enums;

namespace picpay_desafio.Models
{
    public class User
    {
        public User (
            string firstName,
            string lastName,
            string document,
            decimal wallet,
            UserType type,
            Guid Id = default) 
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Wallet = wallet;
            Type = type;
            Active = true;
        }

        public Guid Id { get;  set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal Wallet {  get; private set; }
        public string Document { get; private set; }
        public UserType Type { get; private set; }
        public bool Active { get; private set; }
            
    }
}
