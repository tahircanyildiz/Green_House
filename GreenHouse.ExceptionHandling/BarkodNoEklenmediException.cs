using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class BarkodNoEklenmediException : Exception
    {
        public BarkodNoEklenmediException() { }
        public BarkodNoEklenmediException(string message) : base(message) { }
        public BarkodNoEklenmediException(string message, Exception inner) : base(message, inner) { }
    }
}
