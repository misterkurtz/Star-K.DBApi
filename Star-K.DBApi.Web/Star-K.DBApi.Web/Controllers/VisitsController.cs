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
    public class VisitsController : Controller
    {
        Star_KContext _context = new Star_KContext();


        public ActionResult Index()
        {
            var model =
                from r in _context.Visits
                select new VistsViewModel
                {
                    Visitid = r.Visitid,
                    PlantId = r.PlantId,
                    PersonId = r.PersonId,
                    VisitType = r.VisitType,
                    VisitDate = r.VisitDate,
                    ApproximateDate = r.ApproximateDate,
                    VisitComment = r.VisitComment,
                    EntryDate = r.EntryDate,
                    UserID = r.UserID,
                    WorkflowId = r.WorkflowId
                };
            return View(model);
        }

        //
        // GET: /Visits/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Visits/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Visits/Create

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
        // GET: /Visits/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Visits/Edit/5

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
        // GET: /Visits/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Visits/Delete/5

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
