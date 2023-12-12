using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class HataliUrunFotoGirilmediException : Exception
    {
        public HataliUrunFotoGirilmediException() { }
        public HataliUrunFotoGirilmediException(string message) : base(message) { }
        public HataliUrunFotoGirilmediException(string message, Exception inner) : base(message, inner) { }

    }
}
