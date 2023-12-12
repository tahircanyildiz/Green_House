using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class EmailResetVM
    {
        public Guid ID { get; set; }
        public string OldEmail { get; set; }
        public string NewEmail { get; set; }
        public string Name { get; set; }
        public string Surnama { get; set; }
        public string Password { get; set; }

    }
}
