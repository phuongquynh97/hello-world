using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginMau.ViewModels
{
        public class UserLogin
        {
            [Required(ErrorMessage = "Mời nhập user name")]
            public string name { get; set; }
            public string pw { get; set; }
        }
    
}