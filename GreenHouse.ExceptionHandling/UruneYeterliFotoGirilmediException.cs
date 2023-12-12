using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public  class UruneYeterliFotoGirilmediException : Exception
    {

        public UruneYeterliFotoGirilmediException() { }
        public UruneYeterliFotoGirilmediException(string message) : base(message) { }
        public UruneYeterliFotoGirilmediException(string message, Exception inner) : base(message, inner) { }
    }
}
