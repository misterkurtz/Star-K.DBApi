using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Star_K.DBApi.Web.Models
{
    public class VistsViewModel
    {
        public int Visitid { get; set; }

        public int PlantId { get; set; }

        public int PersonId { get; set; }

        public string VisitType { get; set; }

        public DateTime? VisitDate { get; set; }

        public bool ApproximateDate { get; set; }

        public string VisitComment { get; set; }

        public DateTime? EntryDate { get; set; }

        public int? UserID { get; set; }

        public int? WorkflowId { get; set; }
    }
}