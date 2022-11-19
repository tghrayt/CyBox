using Microsoft.AspNetCore.Mvc;

namespace CyBox.Controllers
{
    public class CyBoxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
