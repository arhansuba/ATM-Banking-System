using Microsoft.AspNetCore.Mvc;

namespace ATM_Banking_System.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
