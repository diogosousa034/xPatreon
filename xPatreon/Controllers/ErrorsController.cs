using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xPatreon.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult NeedToBeCreator()
        {
            return View();
        }
    }
}
