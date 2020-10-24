using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    /// <summary>
    /// 用品领用
    /// </summary>
    public class SuppliesCollectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 用品领用
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            return View();
        }
        /// <summary>
        /// 用品领用申请
        /// </summary>
        /// <returns></returns>
        public IActionResult Registers()
        {
            return View();
        }
        /// <summary>
        /// 用品领用详情
        /// </summary>
        /// <returns></returns>
        public IActionResult Particulars()
        {
            return View();
        }

    }
}