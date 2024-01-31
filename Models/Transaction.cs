namespace ATM_Banking_System.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public decimal Amount { get; set; }
    }
}
