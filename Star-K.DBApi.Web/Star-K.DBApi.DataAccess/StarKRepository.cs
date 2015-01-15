using Star_K.DBApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_K.DBApi.DataAccess
{
    public class StarKRepository : IStarKRepository
    {
        private Star_KContext _db;


        public StarKRepository()
        {
            // TODO: Complete member initialization
            _db = new Star_KContext();
        }



        public IQueryable<Logging> GetAllLogs()
        {
            return _db.Loggings;
        }

        public IQueryable<UkdFile> GetAllFiles()
        {
            return _db.UkdFiles;
        }

        public IQueryable<Visit> GetAllVisits()
        {
            return _db.Visits;
        }

            

    }
}
