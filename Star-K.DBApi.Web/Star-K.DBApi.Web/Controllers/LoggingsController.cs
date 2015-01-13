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

namespace Star_K.DBApi.Web.Controllers
{
    public class LoggingsController : ApiController
    {
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

    }
}