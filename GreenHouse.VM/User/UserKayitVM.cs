﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserKayitVM
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EmailOnayliMi { get; set; } 
        public bool AktifMi { get; set; } 

    }
}
