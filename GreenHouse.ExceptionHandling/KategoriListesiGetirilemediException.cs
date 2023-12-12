using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class KategoriListesiGetirilemediException : Exception
    {
        public KategoriListesiGetirilemediException() { }
        public KategoriListesiGetirilemediException(string message) : base(message) { }
        public KategoriListesiGetirilemediException(string message, Exception inner) : base(message, inner) { }
    }
}
