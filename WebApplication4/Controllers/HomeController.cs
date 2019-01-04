using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // CreateCaseNormal - I Typed this stuff myself!
        public ActionResult CreateCaseNormal()
        {

            ViewBag.Message = "Create New Case";

            return View();
        }

        // CreateCaseNormal - I Typed this stuff myself!
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCaseNormal(WebApplication4.UIModels.CaseNormal model)
        {

            if (ModelState.IsValid)
            {


                // PUT THIS CRAP IN A BUSINESS-LOGIC LAYER

                // You need to map the UI Model to the Entity Framework Model


                // Call a SP to add the Model Data.
                var DaContext = new WebApplication4.Models.Db.DAISYEntities();

                //  var Calls = new 
                DaContext.CreateCaseWrite(model.Name,
                    model.Surname,
                    model.Age,
                    model.Sex,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,);

                DaContext.SaveChanges();
            
                return RedirectToAction("Index");
            }

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