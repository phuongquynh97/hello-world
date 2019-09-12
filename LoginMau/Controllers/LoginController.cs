using LoginMau.LoginDAO;
using LoginMau.Models;
using LoginMau.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMau.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpPost]
        public ActionResult Index(UserLogin userLogin)
        {
            var t = userLogin;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}