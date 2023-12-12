using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDeneme.DAL.Interfaces
{
    public interface IDeletableRepo<T> where T : class
    {
        T HardDelete(T deleted);
        T SoftDelete(T deleted);
    }
}
