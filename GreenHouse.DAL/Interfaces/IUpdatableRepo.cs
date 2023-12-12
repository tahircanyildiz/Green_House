using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDeneme.DAL.Interfaces
{
    public  interface IUpdatableRepo<T> where T : class
    {
        T Update(T updated);
    }
}
