﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace berylliumv2.Models
{
    public class AppUser:IdentityUser
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Age{ get; set; }
    }
}
