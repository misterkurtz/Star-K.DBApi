
namespace Star_K.DBApi.Model
{
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;



    [Table("UserProfiles")]
    public partial class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime Logon { get; set; }

        public string AspxAuth { get; set; }
    }

}
