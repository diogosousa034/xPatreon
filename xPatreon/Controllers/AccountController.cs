using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBase;
using Services;
using Services.Interfaces;
using Services.Dto;

namespace xPatreon.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserDto account)
        {
            if (ModelState.IsValid)
            {
                var username = account.UserName;
                var email = account.Email;
                //if (username is null || email is null)
                //{
                //    ViewBag.RegisterError = "Username and email can not be null !";
                //    return View();
                //}                
                //else
                //{
                //    if (_userService.CheckUserName(username) == false && _userService.CheckEmail(email) == false)
                //    {
                //        _userService.RegisterUser(account);
                //        _userService.CreatePage(account.UserName);
                //        return RedirectToAction("Login", "Account");
                //    }
                //    else
                //    {
                //        ViewBag.RegisterError = "Username or email are already taken !";
                //        return View();
                //    }
                //}

                if (_userService.CheckUserName(username) == false && _userService.CheckEmail(email) == false)
                {
                    _userService.RegisterUser(account);
                    _userService.CreatePage(account.UserName);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ViewBag.RegisterError = "Username or email are already taken !";
                    return View();
                }

                //ModelState.Clear();
            }
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDto user)
        {
            if (_userService.LoginUser(user) == true)
            {               
                HttpContext.Session.SetString("UserID", _userService.UserId(user.UserName).ToString());
                HttpContext.Session.SetString("PageID", _userService.PageId(_userService.UserId(user.UserName)).ToString());
                HttpContext.Session.SetString("Username", user.UserName.ToString());
                HttpContext.Session.SetString("UserImage", _userService.UserInfo(_userService.UserId(user.UserName)).Image.ToString());

                return RedirectToAction("CreatorPosts", "Home");
            }
            else
                ModelState.AddModelError("", "Username or password is wrong.");
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("UserID");
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Login", "Account", new { area = "" });
        }

    }
}


