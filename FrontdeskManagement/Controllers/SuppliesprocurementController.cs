using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    /// <summary>
    /// 用品采购
    /// </summary>
    public class SuppliesprocurementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 用品采购列表
        /// </summary>
        /// <returns></returns>
        public IActionResult List()
        {
            return View();
        }
        /// <summary>
        /// 用品采购登记
        /// </summary>
        /// <returns></returns>
        public IActionResult Registers()
        {
            
            return View();
        }
        /// <summary>
        /// 用品采购详情
        /// </summary>
        /// <returns></returns>
        public IActionResult Particulars()
        {
            return View();
        }
    }
}