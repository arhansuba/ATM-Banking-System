using ATM_Banking_System.Models;

namespace ATM_Banking_System.Services
{
    public class CustomerService
    {
        private readonly List<Customer> _customers; 

        public CustomerService()
        {
            _customers = new List<Customer>
            {
                new() { CustomerId = 1, Name = "John Doe",  }
                
            };
        }

        public void CreateCustomer(Customer customer)
        {
            
            _customers.Add(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            
            return _customers.Find(c => c.CustomerId == customerId);
        }

        
    }
}

