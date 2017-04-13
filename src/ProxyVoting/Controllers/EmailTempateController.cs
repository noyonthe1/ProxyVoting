using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProxyVoting.Controllers
{
    public class EmailTempateController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Email Template";
            return View();
        }
    }
}