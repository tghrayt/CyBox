using CyBox.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CyBox.Controllers
{
    public class CyBoxController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if(userLoginViewModel == null)
            {
                return View();
            }
            return View();
        }
    }
}
