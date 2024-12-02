using Microsoft.AspNetCore.Mvc;

namespace Articles.Controllers
{
    public class SurpriseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
