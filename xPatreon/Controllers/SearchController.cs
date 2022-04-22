using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Dto;
using DataBase;
using Newtonsoft.Json;

namespace xPatreon.Controllers
{
    public class SearchController : Controller
    {

        private IUserService _userService;

        public SearchController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

         [HttpPost]
        public JsonResult GetSearchValue(string search)
        {
            var allSearch = _userService.GetListOfSearchedUsers(search);

            var userSearched = from name in allSearch
                        select name.UserName;


            //string value = string.Empty;
            //value = JsonConvert.SerializeObject(userSearched, Formatting.Indented, new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //});


            return Json(userSearched.ToList());
        }
    }
}
