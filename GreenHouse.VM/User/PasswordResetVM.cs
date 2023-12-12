using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class PasswordResetVM
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public bool EmailOnaylandiMi { get; set; }
        public bool AktifMi { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
