using Microsoft.AspNetCore.Mvc;

namespace KunstWerk.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Copyright()
        {
            return View();
        }
    }
}
