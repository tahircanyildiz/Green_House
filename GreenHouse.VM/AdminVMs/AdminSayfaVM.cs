﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminSayfaVM
    {
        public int ID { get; set; }
        public string SayfaAdi { get; set; }
        public override string ToString()
        {
            return SayfaAdi;
        }
    }
}
