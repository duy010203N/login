using Login.Models;
using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace NVC_AppMVC.Controllers
{
    public class HomeController : Controller
    {
        DangKyModel db = new DangKyModel();
        public ActionResult Index()
        {
            return View();
        }
        // get
        public ActionResult Dangky()
        {
            return View();
        }
        // post
        [HttpPost]
        public ActionResult Dangky(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return Dangky();
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