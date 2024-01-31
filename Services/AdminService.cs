using ATM_Banking_System.Models;

namespace ATM_Banking_System.Services
{
    public class AdminService
    {
        private readonly List<Admin> _admins; 

        public AdminService()
        {
            _admins = new List<Admin>
            {
                new Admin { AdminId = 1, Username = "admin", Password = "admin123" }
                
            };
        }

        public bool ValidateAdmin(Admin admin)
        {
            
            var validAdmin = _admins.Find(a => a.Username == admin.Username && a.Password == admin.Password);
            return validAdmin != null;
        }

        
    }
}

