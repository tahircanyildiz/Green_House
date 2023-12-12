using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class BilesenEklenemediException: Exception
    {
        public BilesenEklenemediException() { }
        public BilesenEklenemediException(string message) : base(message) { }
        public BilesenEklenemediException(string message, Exception inner) : base(message, inner) { }
    }
}
