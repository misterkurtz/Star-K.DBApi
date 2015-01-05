using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Star_K.DBApi.Web.Models
{
    public class UserViewModel
    {
        public int IdUser { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime Logon { get; set; }

        public string AspxAuth { get; set; }
    }
}