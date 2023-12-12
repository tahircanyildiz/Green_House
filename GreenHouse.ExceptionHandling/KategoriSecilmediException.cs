using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public  class KategoriSecilmediException : Exception
    {
        public KategoriSecilmediException() { }
        public KategoriSecilmediException(string message) : base(message) { }
        public KategoriSecilmediException(string message, Exception inner) : base(message, inner) { }
    }
}
