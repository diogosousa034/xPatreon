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

                ViewBag.CountPatrons = _userService.PatronsCount(pageid);

                return View(last4items);
            }
            else
                return RedirectToAction("InitialPage", "Home");

        }


        public IActionResult InitialPage()
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            var items = _userService.GetListOfPages();

            return View(items);

        }

        [HttpPost]
        public IActionResult InitialPage(string pagename)
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            if (pagename != null)
            {
                var items = _userService.GetListOfSearchedPages(pagename);
                return View(items);
            }
            else
                return View(_userService.GetListOfPages());

            

        }


        public IActionResult CreatorPosts()
        {

            if (HttpContext.Session.GetString("UserID") != null)
            {
                var userid = 0;
                int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
                _userService.GetListOfFollowedPages(userid);
                return View();
            }
            else
                return RedirectToAction("InitialPage", "Home");

        }

        public IActionResult CreateContent()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {              
                return View();
            }
            else
                return RedirectToAction("InitialPage", "Home");
        }

        public IActionResult CreateTextContent()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                int contentid = 0;
                int.TryParse(Convert.ToString(HttpContext.Request.Query["EditContent"]), out contentid);

                if (contentid > 0)
                {
                    ViewBag.Title2 = _userService.ContentInfo(contentid).Title;
                    ViewBag.MainContent = _userService.ContentInfo(contentid).MainContent;
                    ViewBag.PublishEdit = "Edit";
                    HttpContext.Session.SetString("ContentPostID", contentid.ToString());
                }
                else
                {
                    ViewBag.PublishEdit = "Publish now";
                }
                

                return View();
            }
            else
                return RedirectToAction("InitialPage", "Home");
        }

        [HttpPost]
        public IActionResult CreateTextContent(CreateContentDto content, string submit)
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            var Contentid = 0;
            int.TryParse(HttpContext.Session.GetString("ContentPostID"), out Contentid);
            if (submit == "Edit")
            {
                content.Content_ID = Contentid;
                _userService.EditContent(content);
            }
            else
            {
                content.Page_ID = pageid;
                _userService.CreateContent(content);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult CreateImageContent()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                int contentid = 0;
                int.TryParse(Convert.ToString(HttpContext.Request.Query["EditContent"]), out contentid);
                if (contentid > 0)
                {
                    ViewBag.Title2 = _userService.ContentInfo(contentid).Title;
                    ViewBag.MainContent = _userService.ContentInfo(contentid).MainContent;
                    ViewBag.Image = "/Images/" + _userService.ContentInfo(contentid).Image;
                    ViewBag.PublishEdit = "Edit";
                    HttpContext.Session.SetString("ContentPostID", contentid.ToString());
                }
                else
                {
                    ViewBag.PublishEdit = "Publish now";
                }
                return View();
            }
            else
                return RedirectToAction("InitialPage", "Home");
        }

        [HttpPost]
        public IActionResult CreateImageContent(CreateContentDto content, string submit)
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);

            var Contentid = 0;
            int.TryParse(HttpContext.Session.GetString("ContentPostID"), out Contentid);

            string uniqueFileName = _userService.UploadedFile(content);

            if (submit == "Edit")
            {
                content.Content_ID = Contentid;
                content.Image = uniqueFileName;
                _userService.EditContent(content);
            }
            else
            {
                content.Page_ID = pageid;
                content.Image = uniqueFileName;
                _userService.CreateContent(content);
            }            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Contentlist()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var pageid = 0;
                int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);

                var items = _userService.ContentList(pageid);

                int contentid = 0;
                int.TryParse(Convert.ToString(HttpContext.Request.Query["ContentIdToDelete"]), out contentid);
                if (contentid > 0)
                {
                    _userService.DeleteContent(contentid);
                    return View(items);
                }

                
                return View(items);
            }
            else
                return RedirectToAction("InitialPage", "Home");
        }

        public IActionResult LaunchedPage()
        {

            int pageid = _userService.PageIdWithPageName(Convert.ToString(HttpContext.Request.Query["UserPageName"]));
            if (pageid > 0)
            {
                ViewBag.pageid = pageid;
                ViewBag.PageName = _userService.PageInfo(pageid).PageName;
                ViewBag.CreatingWhat = _userService.PageInfo(pageid).CreatingWhat;
                ViewBag.ProfileImage = _userService.PageInfo(pageid).ProfileImage;
                ViewBag.CoverImage = _userService.PageInfo(pageid).CoverImage;
                ViewBag.AboutPage = _userService.PageInfo(pageid).AboutPage;
                ViewBag.IsAre = _userService.PageInfo(pageid).IsAreCreating;
                ViewBag.NumberOfFollowers = _userService.PatronsCount(pageid);

                HttpContext.Session.SetString("PageFollowID", pageid.ToString());

                var items = _userService.ContentList(pageid);

                return View(items);                
            }
            return View();
                       
        }

        [HttpPost]
        public IActionResult LaunchedPage(PatronFollowerDto model)
        {                                  
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var userid = 0;
                var pageid = 0;
                int.TryParse(HttpContext.Session.GetString("UserID"), out userid);
                int.TryParse(HttpContext.Session.GetString("PageFollowID"), out pageid);
                model.UserID = userid;
                model.Page_ID = pageid;

                ViewBag.pageid = pageid;
                ViewBag.PageName = _userService.PageInfo(pageid).PageName;
                ViewBag.CreatingWhat = _userService.PageInfo(pageid).CreatingWhat;
                ViewBag.ProfileImage = _userService.PageInfo(pageid).ProfileImage;
                ViewBag.CoverImage = _userService.PageInfo(pageid).CoverImage;
                ViewBag.AboutPage = _userService.PageInfo(pageid).AboutPage;
                ViewBag.IsAre = _userService.PageInfo(pageid).IsAreCreating;
                ViewBag.NumberOfFollowers = _userService.PatronsCount(pageid);

                _userService.Follow(model);

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
                return RedirectToAction("InitialPage", "Home");
        }

        [HttpPost]
        public IActionResult Page(PageEditDto page, string submit)
        {
            var pageid = 0;
            int.TryParse(HttpContext.Session.GetString("PageID"), out pageid);
            if (submit == "Save changes")
            {
                string ProfileImageFileName = _userService.UploadedpageProfilePhoto(page);
                string CoverImageFileName = _userService.UploadedpageCoverPhoto(page);

                page.Page_ID = pageid;
                page.ProfileImage = ProfileImageFileName;
                page.CoverImage = CoverImageFileName;

                _userService.EditPage(page);
                return RedirectToAction("Page", "Home");
            }
            else if(submit == "Launch")
            {
                _userService.LaunchPage(pageid);
                return RedirectToAction("Page", "Home");
            }

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
                return RedirectToAction("InitialPage", "Home");
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


            HttpContext.Session.SetString("Username", user.UserName.ToString());
            HttpContext.Session.SetString("UserImage", _userService.UserInfo(_userService.UserId(user.UserName)).Image.ToString());

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}