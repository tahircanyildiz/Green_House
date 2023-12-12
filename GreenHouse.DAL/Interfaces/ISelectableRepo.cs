using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EfDeneme.DAL.Interfaces
{
    public interface ISelectableRepo<T> where T : class
    {
        T SelectById(string ID);
        List<T> SelectAll();
        List<T> SelectAll(Expression<Func<T,bool>> filter);

        List<T> SelectById(Expression<Func<T,bool>> filter);

        //unitofwork varsa
        //IQueryable<T> SelectAll(Expression<Func<T,bool>> filter);

    }
}
