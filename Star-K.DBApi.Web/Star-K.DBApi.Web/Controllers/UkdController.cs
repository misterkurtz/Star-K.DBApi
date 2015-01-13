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


    }
}
