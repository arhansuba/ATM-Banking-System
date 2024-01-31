namespace ATM_Banking_System.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public decimal Credit { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}

