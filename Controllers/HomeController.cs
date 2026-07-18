using Microsoft.AspNetCore.Mvc;

namespace BibliotecaLocacao.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}