using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class AramaGecmisindenSilinemediException : Exception
    {
        public AramaGecmisindenSilinemediException() { }
        public AramaGecmisindenSilinemediException(string message) : base(message) { }
        public AramaGecmisindenSilinemediException(string message, Exception inner) : base(message, inner) { }
    }
}
