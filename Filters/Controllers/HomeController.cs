using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Message", "Привет от Index из Home-контроллера!");

        //[RequireHttps]
        public IActionResult Index2()
        {
            //if (!Request.IsHttps)
            //{
            //    return new StatusCodeResult(statusCode: 403);
            //}
            return View("Message", "Привет от Index2 из Home-контроллера!");
        }

        //[RequireHttps]
        public IActionResult SecondAction()
        {
            //if (!Request.IsHttps)
            //{
            //    return new StatusCodeResult(statusCode: 403);
            //}
            return View("Message", "Привет от SecondAction из Home-контроллера!");
        }
    }
}
