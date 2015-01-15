using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Star_K.DBApi.Web.Models
{
    public class LoggingViewModel
    {
        public int idLog { get; set; }

        public DateTime Date { get; set; }

        public string transaction { get; set; }
        
        public string idUser { get; set; }

        public string note { get; set; }
    }
}