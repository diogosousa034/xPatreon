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
            if (username != null)
            {
                var userResult = _userService.CheckUserName(username);

                if (userResult != false)
                    return Json(1);
                else
                    return Json(0);
            }
            else
                return Json(null);
        }

        [HttpPost]
        public JsonResult CheckPagenameExits(string pagename, int id)
        {
            if (pagename != null)
            {
                var userResult = _userService.CheckPageName(pagename, id);

                if (userResult != false)
                    return Json(1);
                else
                    return Json(0);
            }
            else
                return Json(null);
        }

        [HttpPost]
        public JsonResult CheckEmailExits(string email)
        {
            if (email != null)
            {
                var userResult = _userService.CheckEmail(email);

                if (userResult != false)
                    return Json(1);
                else
                    return Json(0);
            }
            else
                return Json(null);

        }
    }
}
