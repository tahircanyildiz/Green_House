using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class HataliUrunAciklamasiGirilmedi : Exception
    {
        public HataliUrunAciklamasiGirilmedi() { }
        public HataliUrunAciklamasiGirilmedi(string message) : base(message) { }
        public HataliUrunAciklamasiGirilmedi(string message, Exception inner) : base(message, inner) { }
    }
}
