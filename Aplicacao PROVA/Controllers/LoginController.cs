using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_PROVA.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup() 
        { 
            return View();
        }
    }
}
