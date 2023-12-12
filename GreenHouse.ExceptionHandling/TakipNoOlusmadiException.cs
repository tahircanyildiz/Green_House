using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TakipNoOlusmadiException : Exception
    {
        public TakipNoOlusmadiException() { }
        public TakipNoOlusmadiException(string message) : base(message) { }
        public TakipNoOlusmadiException(string message, Exception inner) : base(message, inner) { }
    }
}
