using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ICalculate calc = new Calculator();
        public HomeController(ICalculate calc)
        {
            this.calc = calc;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Credit credit)
        {
            if (ModelState.IsValid)
            {
                ViewBag.payment = calc.GetPayment(credit);
                return View("Thanks");
            }
            else
                return RedirectToAction("Index");
        }
    }
}