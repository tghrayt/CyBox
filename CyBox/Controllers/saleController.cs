using Microsoft.AspNetCore.Mvc;

namespace CyBox.Controllers
{
    public class saleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
