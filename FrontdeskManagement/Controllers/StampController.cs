using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    public class StampController : Controller
    {
        /// <summary>
        /// 印章列表信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 用章管理信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Show()
        {
            return View();
        }
        /// <summary>
        /// 用章管理详情
        /// </summary>
        /// <returns></returns>
        public IActionResult Back()
        {
            return View();
        }
        /// <summary>
        /// 印章列表详情
        /// </summary>
        /// <returns></returns>
        public IActionResult GetStaParticulars()
        {
            return View();
        }

        /// <summary>
        /// 添加印章信息
        /// </summary>
        /// <returns></returns>
        public IActionResult AddStamp()
        {
            return View();
        }

        /// <summary>
        /// 添加用章管理信息
        /// </summary>
        /// <returns></returns>
        public IActionResult AddBySeal()
        {
            return View();
        }
    }
}
