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
        
        //public StarKRepository(Star_KContext db)
        //{
        //    _db = db;
        //}

        public StarKRepository()
        {
            // TODO: Complete member initialization
            _db = new Star_KContext();
        }

        //public Logging GetLogByDate(DateTime date)
        //{
        //    //return _db.Loggings.Select(u => u.)
        //        var query = from p in _db.Loggings
        //                    where p.DateCreate == date
        //                    select p;

        //    ;
        //}

        public IQueryable<Logging> GetAllLogs()
        {
            var model = from r in _db.Loggings
                        select new Logging
                        {
                            idLogging = r.idLogging,
                            DateCreate = r.DateCreate,
                            transaction = r.transaction,
                            idUser = r.idUser,
                            note = r.note
                        };
            return model;
        }

        //public IQueryable<UkdFile> GetAllFiles()
        //{
        //    var query = from r in _db.UkdFiles
        //                select new UkdFile
        //                {
        //                    UkdFileID = r.UkdFileID

        //                }
        //}


        //public IQueryable<UkdFile> GetAllFiles()
        //{
        //    return _db.UkdFiles
        //              .AsQueryable();
        //}

        //public IQueryable<Visit> GetAllVists()
        //{
        //    return _db.Visits
        //            .AsQueryable();
                    
        //}

            
    }
}
