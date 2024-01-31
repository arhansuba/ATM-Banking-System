using ATM_Banking_System.Models;

namespace ATM_Banking_System.Services
{
    public class AccountService
    {
        private readonly List<Account> _accounts; 

        public AccountService()
        {
            _accounts = new List<Account>
            {
                new Account { AccountId = 1, Name = "John Doe", AccountNumber = "123456789",  }
                
            };
        }

        public void AddAccount(Account account)
        {
            
            _accounts.Add(account);
        }

       
    }
}
