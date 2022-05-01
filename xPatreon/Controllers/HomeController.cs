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
                var pageid = 0;
                int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
                var items = _userService.ContentList(pageid);
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
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            content.Page_ID = pageid;
            _userService.CreateContent(content);

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
        public IActionResult CreateImageContent(CreateContentDto content)
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            string uniqueFileName = _userService.UploadedFile(content);
            content.Page_ID = pageid;
            content.Image = uniqueFileName;
            _userService.CreateContent(content);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Contentlist()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var pageid = 0;
                int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
                var items = _userService.ContentList(pageid);
                return View(items);
            }
            else
                return RedirectToAction("Login", "Account");
        }


        public IActionResult Page()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var pageid = 0;
                int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
                ViewBag.PageName = _userService.PageInfo(pageid).PageName;
                ViewBag.CreatingWhat = _userService.PageInfo(pageid).CreatingWhat;
                ViewBag.ProfileImage = _userService.PageInfo(pageid).ProfileImage;
                ViewBag.CoverImage = _userService.PageInfo(pageid).CoverImage;                
                ViewBag.AboutPage = _userService.PageInfo(pageid).AboutPage;
                ViewBag.IsAre = _userService.PageInfo(pageid).IsAreCreating;

                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Page(PageEditDto page)
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            string ProfileImageFileName = _userService.UploadedpageProfilePhoto(page);
            string CoverImageFileName = _userService.UploadedpageCoverPhoto(page);

            page.Page_ID = pageid;
            page.ProfileImage = ProfileImageFileName;
            page.CoverImage = CoverImageFileName;

            _userService.EditPage(page);

            return RedirectToAction("Page", "Home");
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