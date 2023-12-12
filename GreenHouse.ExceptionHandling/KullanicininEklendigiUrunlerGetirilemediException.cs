using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class KullanicininEklendigiUrunlerGetirilemediException : Exception
    {
        public KullanicininEklendigiUrunlerGetirilemediException() { }
        public KullanicininEklendigiUrunlerGetirilemediException(string message) : base(message) { }
        public KullanicininEklendigiUrunlerGetirilemediException(string message, Exception inner) : base(message, inner) { }
    }
}
