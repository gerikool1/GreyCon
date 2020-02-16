using GreyCon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreyCon.Controllers
{
    public class DisksInputController : Controller
    {
        // GET: DisksInput
        public ActionResult Index()
        {
            return View();
        }

        // GET: DisksInput/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DisksInput/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisksInput/Create
        [HttpPost]
        public ActionResult Create(int UsedMbs, int TotalMbs)
        {
            var model = new DisksInputViewModel();
            var UsedSpace = new List<int>();
            var TotalSpace = new List<int>();

            UsedSpace.Add(UsedMbs);
            TotalSpace.Add(TotalMbs);

            DiskSpace.MinDrives(UsedSpace,TotalSpace);
            /* try
              {
                  // TODO: Add insert logic here

                  return RedirectToAction("Create");
              }
              catch
              {
                  return View();
              }*/
            return View();
        }

        // GET: DisksInput/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DisksInput/Edit/5
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

        // GET: DisksInput/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DisksInput/Delete/5
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
