using ATM_Banking_System.Models;

namespace ATM_Banking_System.Services
{
    public class TransactionService
    {
        private readonly List<Transaction> _transactions; 

        public TransactionService()
        {
            _transactions = new List<Transaction>
            {
                new Transaction { TransactionId = 1, CustomerId = 1, TransactionTime = DateTime.Now, Amount = 100 }
                
            };
        }

        public void AddTransaction(Transaction transaction)
        {
            
            _transactions.Add(transaction);
        }

       
    }
}
