﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtRsaAPI.Models
{
    public class AuthenticationModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
