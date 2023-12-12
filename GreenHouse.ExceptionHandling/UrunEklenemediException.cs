using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UrunEklenemediException : Exception
    {
        public UrunEklenemediException() { }
        public UrunEklenemediException(string message) : base(message) { }
        public UrunEklenemediException(string message, Exception inner) : base(message, inner) { }
    }
}
