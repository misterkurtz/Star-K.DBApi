using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Star_K.DBApi.DataAccess;
using Star_K.DBApi.Model;
using Star_K.DBApi.Web.Models;

namespace Star_K.DBApi.Web.Controllers
{
    public class LoggingsController : ApiController
    {
        
        

        //Auto generated using the entity framework 

        private Star_KContext db = new Star_KContext();

        // GET: api/Loggings
        public IQueryable<Logging> GetLoggings()
        {
            return db.Loggings;
        }

        // GET: api/Loggings/5
        [ResponseType(typeof(Logging))]
        public IHttpActionResult GetLogging(int id)
        {
            Logging logging = db.Loggings.Find(id);
            if (logging == null)
            {
                return NotFound();
            }

            return Ok(logging);
        }

        //IStarKRepository _repo;
        //private ModelFactory _modelFactory;

        //public LoggingsController(IStarKRepository repo)
        //{
        //    _repo = repo;
        //    _modelFactory = new ModelFactory();

        //}

        ////Returning the date from the logging context using a viewmodel, and modelfactory
        //public IEnumerable<LoggingViewModel> Get()
        //{
        //    var results = _repo.GetAllLogs()
        //                 .ToList()
        //                 .Select(l => _modelFactory.Create(l));

        //    return results;
        //}

        //public LoggingViewModel Get(DateTime date)
        //{
        //    return _modelFactory.Create(_repo.GetDate(date));
        //}

    }
}