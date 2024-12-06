using Microsoft.AspNetCore.Mvc;

namespace RegLog.Controllers
{
    public class BankController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
