﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginSystem.Models
{
    public class User
    {
        //[Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
    }
}