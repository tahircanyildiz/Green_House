using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class GirisYapilmadiException : Exception
    {
        public GirisYapilmadiException() { }
        public GirisYapilmadiException(string message) : base(message) { }
        public GirisYapilmadiException(string message, Exception inner) : base(message, inner) { }
    }
}
