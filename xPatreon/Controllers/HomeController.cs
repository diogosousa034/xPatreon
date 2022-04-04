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
using Services.Interfaces;

namespace xPatreon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;
        private xPatreonDbContext _context;

        public HomeController(ILogger<HomeController> logger, IUserService userService, xPatreonDbContext context)
        {
            _context = context;
            _logger = logger;
            _userService = userService;
        }


        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var userid = 0;
                int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
                var items = _userService.ContentList(userid);
                var last5items = items.Reverse().Take(4);

                return View(last5items);
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

        public IActionResult CreateTextContent()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }

       

        [HttpPost]
        public IActionResult CreateTextContent(UserContent content, User user)
        {
            var userid = 0;
            int.TryParse(HttpContext.Session.GetString("UserID"), out userid);

            _userService.CreateContent(content.Title, content.MainContent, content.Image, userid);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult CreateImageContent()
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