namespace Star_K.DBApi.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(40)]
        public string UserName { get; set; }

        [StringLength(40)]
        public string Password { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? Logon { get; set; }

        [StringLength(400)]
        public string AspxAuth { get; set; }
    }
}
