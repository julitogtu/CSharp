using AutoMapperValueResolver.Models;
using System.Web.Mvc;

namespace AutoMapperValueResolver.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new ClientRepository();
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