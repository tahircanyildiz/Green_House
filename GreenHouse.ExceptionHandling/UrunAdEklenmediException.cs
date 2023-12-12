using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UrunAdEklenmediException : Exception
    {
        public UrunAdEklenmediException() { }
        public UrunAdEklenmediException(string message) : base(message) { }
        public UrunAdEklenmediException(string message, Exception inner) : base(message, inner) { }
    }
}
