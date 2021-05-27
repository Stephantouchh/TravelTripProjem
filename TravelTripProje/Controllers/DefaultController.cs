using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default 
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public ActionResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(degerler);
        }
        public ActionResult Partial3()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return PartialView(degerler);
        }
        public ActionResult Partial4()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public ActionResult Partial5()
        {
            var degerler = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(degerler);
        }
    }
}