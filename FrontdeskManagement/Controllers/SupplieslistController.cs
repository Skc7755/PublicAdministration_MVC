using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    /// <summary>
    /// 用户列表
    /// </summary>
    public class SupplieslistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 用品列表
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            return View();
        }
        /// <summary>
        /// 用品登记
        /// </summary>
        /// <returns></returns>
        public IActionResult Registers()
        {
            return View();
        }
        /// <summary>
        /// 用品详情
        /// </summary>
        /// <returns></returns>
        public IActionResult Particulars()
        {
            return View();
        }

    }
}