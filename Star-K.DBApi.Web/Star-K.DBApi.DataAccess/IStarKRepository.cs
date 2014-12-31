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
        //Logging GetLogByDate(DateTime date);
          IQueryable<Logging> GetAllLogs();

          //IQueryable<UkdFile> GetAllFiles();
        
//        IQueryable<Visit> GetAllVists();




      
    }

}
       