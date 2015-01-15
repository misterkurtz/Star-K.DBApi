using Star_K.DBApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Star_K.DBApi.Web.Models
{
    public class ModelFactory
    {
        public LoggingViewModel Create(Logging logging)
        {
             return new LoggingViewModel
                {
                    idLog = logging.idLogging,
                    Date = logging.DateCreate ?? DateTime.Now,
                    transaction = logging.transaction,
                    idUser = logging.idUser,
                    note = logging.note
                };
        }
    }
}