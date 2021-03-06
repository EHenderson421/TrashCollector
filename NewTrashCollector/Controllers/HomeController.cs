﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewTrashCollector.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Home()
        {
            bool role = User.IsInRole("Admin");
            if (role)
            {
                return RedirectToAction("AdminHome", "Customers");
            }
            role = User.IsInRole("Employee");
            if (role)
            {
                return RedirectToAction("EmployeeHome", "Customers");
            }
            role = User.IsInRole("Customer");
            if (role)
            {
                return RedirectToAction("CustomerHome", "Customers");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}