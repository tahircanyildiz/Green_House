using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YasalIfadelerKullanıldıException : Exception
    {
        public YasalIfadelerKullanıldıException() { }
        public YasalIfadelerKullanıldıException(string message) : base(message) { }
        public YasalIfadelerKullanıldıException(string message, Exception inner) : base(message, inner) { }
    }
}
