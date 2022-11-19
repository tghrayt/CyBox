using Microsoft.AspNetCore.Mvc;

namespace CyBox.Controllers
{
    public class ProspectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
