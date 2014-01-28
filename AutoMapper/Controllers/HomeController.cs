using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.Models;

namespace AutoMapper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new ClientRepository();
            var obj = repo.GetClientViewModelById(1);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}