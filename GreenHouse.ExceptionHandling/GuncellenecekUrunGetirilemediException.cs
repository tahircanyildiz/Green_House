using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class GuncellenecekUrunGetirilemediException : Exception
    {
        public GuncellenecekUrunGetirilemediException() { }
        public GuncellenecekUrunGetirilemediException(string message) : base(message) { }
        public GuncellenecekUrunGetirilemediException(string message, Exception inner) : base(message, inner) { }
    }
}
