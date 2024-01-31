using Microsoft.AspNetCore.Mvc;
using ATM_Banking_System.Models;
using ATM_Banking_System.Services;

namespace ATM_Banking_System.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult CreateCustomer()
        {
            // CreateCustomer sayfasını görüntüle
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            // Yeni müşteriyi oluştur
            _customerService.CreateCustomer(customer);
            // Ana sayfaya yönlendir
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ViewCustomer()
        {
            // ViewCustomer sayfasını görüntüle
            return View();
        }

        public IActionResult AddAccountDetails()
        {
            // AddAccountDetails sayfasını görüntüle
            return View();
        }

        public IActionResult TransactionDetails()
        {
            // TransactionDetails sayfasını görüntüle
            return View();
        }

        public IActionResult Details(int id)
        {
            // Müşteri detaylarını getir
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
    }
}


