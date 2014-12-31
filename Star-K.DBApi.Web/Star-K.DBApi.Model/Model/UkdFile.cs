namespace Star_K.DBApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("UkdFile")]
    public partial class UkdFile
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
