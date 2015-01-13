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
    public class UkdFilesController : ApiController
    {
        private Star_KContext db = new Star_KContext();

        // GET: api/UkdFiles
        public IQueryable<UkdFile> GetUkdFiles()
        {
            return db.UkdFiles;
        }

        // GET: api/UkdFiles/5
        [ResponseType(typeof(UkdFile))]
        public IHttpActionResult GetUkdFile(int id)
        {
            UkdFile ukdFile = db.UkdFiles.Find(id);
            if (ukdFile == null)
            {
                return NotFound();
            }

            return Ok(ukdFile);
        }


    }
}