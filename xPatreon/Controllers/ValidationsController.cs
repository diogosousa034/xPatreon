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
    public class ValidationsController : Controller
    {
        private IUserService _userService;

        public ValidationsController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CheckUsernameExits(string username)
        {
            var userResult = _userService.CheckUserName(username);

            if (userResult != false)
                return Json(1);
            else
                return Json(0);
            
        }

        [HttpPost]
        public JsonResult CheckEmailExits(string email)
        {
            var userResult = _userService.CheckEmail(email);

            if (userResult != false)
                return Json(1);
            else
                return Json(0);

        }

    }
}
