using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Star_K.DBApi.DataAccess;
using Star_K.DBApi.Model;
using Star_K.DBApi.Web.Models;

namespace Star_K.DBApi.Web.Controllers
{
    public class UkdController : Controller
    {
        //
        // GET: /Ukd/

        Star_KContext _context = new Star_KContext();

        public ActionResult Index()
        {
            var model =
                from r in _context.UkdFiles
                select new UkdViewModel
                {
                    UkdFileID = r.UkdFileID,
                    AgencyID = r.AgencyID,
                    FileDay = r.FileDay,
                    FileMonth = r.FileMonth,
                    FileYear = r.FileYear,
                    DateUpdated = r.DateUpdated ?? DateTime.Now,
                    Bytes = r.Bytes
                };
            return View(model);
        }

        //
        // GET: /Ukd/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Ukd/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ukd/Create

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

        //
        // GET: /Ukd/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ukd/Edit/5

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

        //
        // GET: /Ukd/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Ukd/Delete/5

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
