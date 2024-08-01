using Microsoft.AspNetCore.Mvc;

namespace scopewebsite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult loginpage()
        {
            return View();
        }
    }
}
