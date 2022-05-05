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
            var allSearch = _userService.GetListOfSearchedPages(search);

            var activePages = allSearch.Where(a => a.active == true);

            var userSearched = from name in activePages
                               select name.PageName;

            return Json(userSearched.ToList());
        }
    }
}
