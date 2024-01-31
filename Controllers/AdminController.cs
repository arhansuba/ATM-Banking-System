using Microsoft.AspNetCore.Mvc;
using ATM_Banking_System.Models;
using ATM_Banking_System.Services;

namespace ATM_Banking_System.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            
            if (_adminService.ValidateAdmin(admin))
            {
                
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
               
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }

       
        public IActionResult Dashboard()
        {
            
            return View();
        }

        
    }
}

