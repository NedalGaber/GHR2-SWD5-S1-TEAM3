using Microsoft.AspNetCore.Mvc;

namespace TechEXpress.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
