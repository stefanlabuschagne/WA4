using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class CaseNormalController : Controller
    {
        // GET: CaseNormal
        public ActionResult Index()
        {
            return View();
        }

        // GET: CaseNormal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CaseNormal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaseNormal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                // Ths Cans everything.

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CaseNormal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CaseNormal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CaseNormal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CaseNormal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
