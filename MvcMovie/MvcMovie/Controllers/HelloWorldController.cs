﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        public ActionResult Welcome(string name, int ID = 1)
        {
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
            ViewBag.Message = "Hello " + name;
            ViewBag.ID = ID;
            return View();
        }
    }
}