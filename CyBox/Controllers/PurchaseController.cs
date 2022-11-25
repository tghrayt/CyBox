using Microsoft.AspNetCore.Mvc;

namespace CyBox.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
