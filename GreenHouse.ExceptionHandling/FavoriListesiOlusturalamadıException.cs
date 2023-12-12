using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class FavoriListesiOlusturalamadıException : Exception
    {
        public FavoriListesiOlusturalamadıException() { }
        public FavoriListesiOlusturalamadıException(string message) : base(message) { }
        public FavoriListesiOlusturalamadıException(string message, Exception inner) : base(message, inner) { }
    }
}
