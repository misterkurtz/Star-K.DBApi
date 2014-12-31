using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Star_K.DBApi.Web.Models
{
    public class UkdViewModel
    {
        public int UkdFileID { get; set; }

        public int? AgencyID { get; set; }

        public int? FileDay { get; set; }

        public int? FileMonth { get; set; }

        public int? FileYear { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string Bytes { get; set; }
    }
}