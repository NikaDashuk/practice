using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4;
using WebApplication4.Models;
using System.Data.Entity;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();

        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult users()
        {
            return View();
        }
        public ActionResult NewUser()
        {
            return View();
        }
        public ActionResult volunteer()
        {
            return View();
        }
        
        


    }
}