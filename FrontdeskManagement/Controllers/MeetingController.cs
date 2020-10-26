using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Show1()
        {
            return View();
        }
        public IActionResult ManShow(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult ManAdd()
        {
            return View();
        }
        public IActionResult ConAdd()
        {
            return View();
        }
        public IActionResult ConShow(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}