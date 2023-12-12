using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UreticiSirketListesiGetirilemediException : Exception
    {
        public UreticiSirketListesiGetirilemediException() { }
        public UreticiSirketListesiGetirilemediException(string message) : base(message) { }
        public UreticiSirketListesiGetirilemediException(string message, Exception inner) : base(message, inner) { }
    }
}
