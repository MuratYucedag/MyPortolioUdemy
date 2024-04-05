using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
