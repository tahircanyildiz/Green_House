using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UrunIcerigiGirilmediException : Exception
    {
        public UrunIcerigiGirilmediException() { }
        public UrunIcerigiGirilmediException(string message) : base(message) { }
        public UrunIcerigiGirilmediException(string message, Exception inner) : base(message, inner) { }
    }
}
