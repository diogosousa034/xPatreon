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
using Services.Dto;

namespace xPatreon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _userService;

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
                var last4items = items.Reverse().Take(4);

                return View(last4items);
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
        public IActionResult CreateTextContent(CreateContentDto content)
        {
            var userid = 0;
            int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
            content.User_ID = userid;
            _userService.CreateContent(content);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult CreateImageContent()
        {
            //if (HttpContext.Session.GetString("UserID") != null)
            //{
            //    return View();
            //}
            //else
            //    return RedirectToAction("Login", "Account");
            return View();
        }

        [HttpPost]
        public IActionResult CreateImageContent(CreateContentDto content)
        {
            var userid = 0;
            int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
            string uniqueFileName = _userService.UploadedFile(content);
            content.User_ID = userid;
            content.Image = uniqueFileName;
            _userService.CreateContent(content);
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

        public IActionResult Settings()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var userid = 0;
                int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
                ViewBag.image = _userService.UserInfo(userid).Image;
                ViewBag.username = _userService.UserInfo(userid).UserName;
                ViewBag.email = _userService.UserInfo(userid).Email;

                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Settings(UserDto  user)
        {
            var userid = 0;
            int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
            string uniqueFileName = _userService.UploadedFileUser(user);

            user.User_ID = userid;
            user.Image = uniqueFileName;

            _userService.EditUser(user);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}