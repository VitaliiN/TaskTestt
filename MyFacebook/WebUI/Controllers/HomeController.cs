using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Core;
using DomainModel.Domain;

namespace WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        private readonly UserRepository userRepository;
        public HomeController ( )
        {
           
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
