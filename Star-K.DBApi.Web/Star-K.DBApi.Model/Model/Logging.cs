namespace Star_K.DBApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("Logging")]
    public partial class Logging
    {
        [Key]
        public int idLogging { get; set; }

        public DateTime? DateCreate { get; set; } 

        [StringLength(100)]
        public string transaction { get; set; }

        [StringLength(100)]
        public string idUser { get; set; }

        public string note { get; set; } 
    }
}
