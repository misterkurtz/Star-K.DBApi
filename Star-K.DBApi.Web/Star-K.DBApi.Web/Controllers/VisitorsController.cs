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
    public class VisitorsController : ApiController
    {
        private Star_KContext db = new Star_KContext();

        // GET: api/Visitors
        public IQueryable<Visit> GetVisits()
        {
            return db.Visits;
        }

        // GET: api/Visitors/5
        [ResponseType(typeof(Visit))]
        public IHttpActionResult GetVisit(int id)
        {
            Visit visit = db.Visits.Find(id);
            if (visit == null)
            {
                return NotFound();
            }

            return Ok(visit);
        }

    }
}