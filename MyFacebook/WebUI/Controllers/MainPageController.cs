using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Core;
using DomainModel.Domain;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class MainPageController : Controller
    {
        private readonly UserRepository userRepository;
        public MainPageController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        //
        // GET: /MainPage/

        public ActionResult Index(int id)
        {
            var model = new MainPageViewModel();
            model.Friends = userRepository.GetFriendsById(id);

            return View();
        }

    }
}
