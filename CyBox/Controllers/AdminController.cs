﻿using Microsoft.AspNetCore.Mvc;

namespace CyBox.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}