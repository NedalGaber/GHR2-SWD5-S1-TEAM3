using Microsoft.AspNetCore.Mvc;

namespace TechEXpress.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
