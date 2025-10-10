using Microsoft.AspNetCore.Mvc;

namespace cursodevops.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
