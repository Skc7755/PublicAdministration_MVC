using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontdeskManagement.Controllers
{
    public class CertificationsController : Controller
    {
        /// <summary>
        /// 证照列表信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 证照借用信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Show()
        {
            return View();
        }
        /// <summary>
        /// 证照列表详情
        /// </summary>
        /// <returns></returns>
        public IActionResult Back()
        {
            return View();
        }
        /// <summary>
        /// 证照借用详情
        /// </summary>
        /// <returns></returns>
        public IActionResult GetLicParticulars()
        {
            return View();
        }

        /// <summary>
        /// 添加证照列表
        /// </summary>
        /// <returns></returns>
        public IActionResult AddCertification()
        {
            return View();
        }

        /// <summary>
        /// 添加证照借用信息
        /// </summary>
        /// <returns></returns>
        public IActionResult AddLicense()
        {
            return View();
        }
    }
}
