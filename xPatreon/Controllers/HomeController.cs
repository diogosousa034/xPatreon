using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using xPatreon.Models;
using DataBase;
using Services;
using Microsoft.AspNetCore.Http;

namespace xPatreon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Account");

        }

        public IActionResult CreatorPosts()
        {

            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Account");

        }

        public IActionResult CreateContent()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}