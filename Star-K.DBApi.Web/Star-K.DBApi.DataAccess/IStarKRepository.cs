using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_K.DBApi.Model;


namespace Star_K.DBApi.DataAccess
{
    public interface IStarKRepository
    {

          IQueryable<Logging> GetAllLogs();
          //Logging GetLog(int id);
          //Logging GetDate(DateTime date);
            

          IQueryable<UkdFile> GetAllFiles();
        
          IQueryable<Visit> GetAllVisits();




      
    }

}
       