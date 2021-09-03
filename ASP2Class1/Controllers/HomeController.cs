using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        // Creates the ViewBag variables and sets them to 0 on startup.  // 
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Tip15 = 0; 
            ViewBag.Tip20 = 0; 
            ViewBag.Tip25 = 0;
            return View();
        }

        // Takes input from the model and inserts it into the view if the criteria is met. //
        [HttpPost]
        public IActionResult Index(TipCalcModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = model.CalculateTip15(); 
                ViewBag.Tip20 = model.CalculateTip20(); 
                ViewBag.Tip25 = model.CalculateTip25();
            }
            else
            {
                ViewBag.Tip15 = 0;
                ViewBag.Tip20 = 0;
                ViewBag.Tip25 = 0;
            }
            return View();
        }
    }
}
