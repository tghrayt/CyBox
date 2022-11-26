using CyBox.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CyBox.Controllers
{
    public class CyBoxController : Controller
    {
        private readonly ILogger _logger;
        public CyBoxController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime now = DateTime.Now;
            ViewData["date"] = now.Year;
            return View();
        }
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if(userLoginViewModel == null)
            {
                _logger.LogError("");
                return View("Error");
            }
            return View();
        }
    }
}
