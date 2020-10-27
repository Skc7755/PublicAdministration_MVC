using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    public class DefaultController : Controller
    {
        /// <summary>
        /// 资产管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VehicleInfoList()
        {
            return View();
        }
        public IActionResult AddCar()
        {
            return View();
              
        }
        public IActionResult CarDetail(int id)
        {
            ViewData["id"] = id;
            return View();
        }
        public IActionResult CarApplicationList()
        {
            return View();
        }
        public IActionResult CarApplicationDetail(int id)
        {
            ViewData["id"] = id;
            return View();
        }
        public IActionResult AIRList()
        {
            return View();
        }
        public IActionResult AIRDetail(int id)
        {
            ViewData["id"] = id;
            return View();

        }
        public IActionResult VMRList()
        {
            return View();
        }
        public IActionResult VMRDetail(int id)
        {
            ViewData["id"] = id;
            return View();

        }
        public IActionResult AIROVList()
        {
            return View();
        }
        public IActionResult AIROVDetail(int id)
        {
            ViewData["id"] = id;
            return View();

        }
        public IActionResult VRRList()
        {
            return View();
        }
        public IActionResult VRRDetail(int id)
        {
            ViewData["id"] = id;
            return View();

        }
        public IActionResult VARList()
        {
            return View();
        }
        public IActionResult VARDetail(int id)
        {
            ViewData["id"] = id;
            return View();

        }
        public IActionResult AssetsList()
        {
            return View();
        }
        public IActionResult AssetsListDetail(int id)
        {

            ViewData["id"] = id;
            return View();
            
        }
        public IActionResult CFAList()
        {
            return View();
        }
        public IActionResult CFAListDetail(int id)
        {
            ViewData["id"] = id;
            return View();
        
        }
        public IActionResult AfarList()
        {
            return View();
        
        }
        public IActionResult AfarListDetail(int id)
        {
            ViewData["id"] = id;
            return View();
        }
        public IActionResult APAList()
        {
            return View();
        }
        public IActionResult APAListDetail(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}