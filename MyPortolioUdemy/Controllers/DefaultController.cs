using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
