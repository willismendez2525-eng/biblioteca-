using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
