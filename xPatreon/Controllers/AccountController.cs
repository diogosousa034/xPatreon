using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBase;
using Services;
using Services.Interfaces;

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
        public IActionResult Register(User account)
        {
            if (ModelState.IsValid)
            {
                _userService.RegisterUser(account.UserName, account.Email, account.Password, account.ConfirmPassword, account.Role);

                ModelState.Clear();
                ViewBag.Message = account.UserName + " successfuly registered";
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (_userService.LoginUser(user.UserName, user.Password) == true)
            {
                HttpContext.Session.SetString("UserID", _userService.UserId(user.UserName).ToString());
                HttpContext.Session.SetString("Username", user.UserName.ToString());

                return RedirectToAction("Index", "Home");
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
