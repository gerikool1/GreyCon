using GreyCon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GreyCon.Controllers
{
    public class DiskSpaceController : Controller
    {
        // GET: DiskSpace
        public ActionResult Index()
        {
            List<int> listUsed = new List<int> { 350, 800, 450 };
            List<int> listTest = new List<int> { 600, 1000, 500 };

            DiskSpace.MinDrives(listUsed, listTest);

                       return View();
        }

        // GET: DiskSpace/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DiskSpace/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiskSpace/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DiskSpace/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiskSpace/Edit/5
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

        // GET: DiskSpace/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiskSpace/Delete/5
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
