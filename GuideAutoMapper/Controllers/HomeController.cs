using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuideAutoMapper.Models;

namespace GuideAutoMapper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new ClientRepository();
            //var clientvm = repo.GetById(1);
            //var clientvm2 = repo.GetByIdWithProfile(1);
            var clientall = repo.GetAll();
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