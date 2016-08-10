using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //OdpContext1 db = new OdpContext1();
            //var list = db.BASE_CIQCODE.First();
            // list.CIQNAME = "CIQL";
           
            //db.SaveChanges();
            StoreContext db = new StoreContext();
            var item = db.Products.First();
            item.ObjectState = Repository.Pattern.Infrastructure.ObjectState.Modified;
            item.Name = "__________";
            db.SaveChanges();

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