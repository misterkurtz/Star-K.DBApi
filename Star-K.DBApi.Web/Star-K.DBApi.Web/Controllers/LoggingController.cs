using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Star_K.DBApi.DataAccess;
using Star_K.DBApi.Model;
using Star_K.DBApi.Web.Models;
using System.Web.Http;





namespace Star_K.DBApi.Web.Controllers
{

    public class LoggingController : Controller
    {

        //public LoggingController ()
        //{

        //}

        //private readonly IStarKRepository _repo;

        //StarKRepository _StarKRepository = new StarKRepository()
        //    {
        //    };



        //private readonly StarKRepository _repo;

        //public LoggingController()//IStarKRepository repo)
        //{
        //    //_repo = repo;
        //    _repo = new StarKRepository();
        //}

        Star_KContext _context = new Star_KContext();

           [System.Web.Mvc.HttpGet] 
       public ActionResult Index()
        {
            var model =
                from r in _context.Loggings
                select new LoggingViewModel
                {
                    idLog = r.idLogging,
                    Date = r.DateCreate ?? DateTime.Now,
                    transaction = r.transaction,
                    idUser = r.idUser,
                    note = r.note
                };
            return View(model);



        }

        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Logging logging = _context.Loggings.Find(id);
        //    if (logging == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(logging);
        //}


    }




}