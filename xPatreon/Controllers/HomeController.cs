using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xPatreon.Models;
using DataBase;
using Services;
using Microsoft.AspNetCore.Http;
using Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace xPatreon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;
        private readonly xPatreonDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
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

        [HttpPost]
        public IActionResult CreateImageContent(UserContent content)
        {
            var userid = 0;
            int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
            string uniqueFileName = _userService.UploadedFile(content);
            _userService.CreateContent(content.Title, content.MainContent, uniqueFileName, userid);
            return RedirectToAction("Index", "Home");
        }    

        public IActionResult Contentlist()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var userid = 0;
                int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
                var items = _userService.ContentList(userid);
                return View(items);
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