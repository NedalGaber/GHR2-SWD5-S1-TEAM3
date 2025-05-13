using Microsoft.AspNetCore.Mvc;

namespace TechXpress.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
