using Microsoft.AspNetCore.Mvc;

namespace TechEXpress.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
