using Microsoft.AspNetCore.Mvc;

namespace TechXpress.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult EditProfile()
        {
            return View();
        }
    }
}
