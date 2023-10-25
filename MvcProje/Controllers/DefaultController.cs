using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
