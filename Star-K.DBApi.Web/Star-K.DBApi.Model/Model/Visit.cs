namespace Star_K.DBApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class Visit
    {
        public int Visitid { get; set; }

        public int PlantId { get; set; }

        public int PersonId { get; set; }

        [StringLength(128)]
        public string VisitType { get; set; }

        public DateTime? VisitDate { get; set; }

        public bool ApproximateDate { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string VisitComment { get; set; }

        public DateTime? EntryDate { get; set; }

        public int? UserID { get; set; }

        public int? WorkflowId { get; set; }
    }
}
