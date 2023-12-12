using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public  class GenelNullException : Exception
    {
        public GenelNullException() { }
        public GenelNullException(string message) : base(message) { }
        public GenelNullException(string message, Exception inner) : base(message, inner) { }
    }
}
