using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ProxyVoting.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Campaign()
        {
            ViewBag.Title = "Create Campaign";
            return View();
        }

        public IActionResult AddQuestions()
        {
            ViewBag.Title = "Add Resolution";
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Campaign Dashboard";
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Import()
        {
            ViewBag.Title = "Import Shareholders";
            return View();
        }

        public IActionResult Ballot()
        {
            ViewBag.Title = "Participate Proxy voting";
            return View();
        }

    }
}
