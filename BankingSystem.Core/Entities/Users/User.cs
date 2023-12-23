using BankingSystem.Core.Entities.Balances;
using BankingSystem.Core.Entities.Bills;
using BankingSystem.Core.Entities.Transactions;
using BankingSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Entities.Users
{
    public class User : Entity
    {
        private User()
        {}

        public User(string firstName,
                    string lastName,
                    string password,
                    string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
        }

        public string FirstName { get; private set; } = default!;
        public string LastName { get; private set; } = default!;
        public string Password { get; private set; } = default!;
        public string Email { get; private set; } = default!;
        public UserStatuses Status { get; private set; }

        public Balance? Balance { get; set; } = default!;
        public ICollection<Transaction>? Transactions { get; set; } = default!;
        public ICollection<Bill>? Bills { get; set; } = default!;
        public ICollection<Bill>? RecipientBills { get; set; } = default!;
    }
}
