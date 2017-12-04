using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcSimpleInjector.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository;

        public HomeController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Usernames = userRepository.GetAllUsernames();
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