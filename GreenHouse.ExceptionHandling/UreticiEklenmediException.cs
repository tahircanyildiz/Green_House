using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UreticiEklenmediException : Exception
    {
        public UreticiEklenmediException() { }
        public UreticiEklenmediException(string message) : base(message) { }
        public UreticiEklenmediException(string message, Exception inner) : base(message, inner) { }
    }
}
