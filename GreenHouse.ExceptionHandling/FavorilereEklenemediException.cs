using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class FavorilereEklenemediException : Exception
    {
        public FavorilereEklenemediException() { }
        public FavorilereEklenemediException(string message) : base(message) { }
        public FavorilereEklenemediException(string message, Exception inner) : base(message, inner) { }

    }
}
