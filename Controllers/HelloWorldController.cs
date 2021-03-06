using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //    //return View();
        //    return "This is my <b>default</b> action...";
        //}

        public ActionResult Index()
        {
            return View();
        }

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}