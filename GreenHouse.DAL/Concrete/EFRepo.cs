using EfDeneme.DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EfDeneme.DAL.Concrete
{
    public class EFRepo<T> : IDeletableRepo<T>, IInsertableRepo<T>, IUpdatableRepo<T>, ISelectableRepo<T> where T : class
    {
        private readonly DbContext _db;
        private readonly DbSet<T> _table;

        public EFRepo(Model1 context)
        {
            _db = context;
            _table = context.Set<T>();
        }
        public EFRepo()
        { // burada bir sorun olabilir bak
            Model1 context = new Model1();
            _db = context;
            _table = _db.Set<T>();
        }
        public T Add(T inserted)
        {
            
           T returnsData = _table.Add(inserted);
            _db.SaveChanges();
            return returnsData;
        }

        public T HardDelete(T deleted)
        {
            T returnsData = _table.Attach(deleted);
            _db.Entry(deleted).State = EntityState.Deleted;
            _db.SaveChanges();
            return returnsData;
           //T returnsData = _table.Remove(deleted);
           // _db.SaveChanges();
           // return returnsData;
        }

        public List<T> SelectAll()
        {
            return _table.ToList();
        }

        public List<T> SelectAll(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).ToList();
        }

        public T SelectById(string ID)
        {
            return _table.Find(ID);
        }
        public T SelectByID(Guid ID)
        {
            return _table.Find(ID);
        }
        public T SelectByID(int ID)
        {
            return _table.Find(ID);
        }

        public T SelectOneById(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).FirstOrDefault();
        }
        public List<T> SelectById(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).ToList();
        }


        //aktifmi  alanı olduğunu biliyoruz
        public T SoftDelete(T deleted)
        {
            T returnsData;
            if(deleted.GetType().GetProperty("AktifMi") != null)
            {
                //AktifMi kolonu var
                T _entity = deleted;
                _entity.GetType().GetProperty("AktifMi").SetValue(_entity, false);
                returnsData = Update(_entity);
            }
            else
            {
                //AktifMi kolonu yok
                //DbEntityEntry dbEntityEntry = _db.Entry(deleted);
                //if (dbEntityEntry.State != EntityState.Deleted)
                //{
                //    dbEntityEntry.State = EntityState.Deleted;
                //    _table.Attach(deleted);
                //    _table.Remove(deleted);
                //    _db.SaveChanges();
                //}
                //else
                //{
                //    HardDelete(deleted);
                //}
                DbEntityEntry dbEntityEntry = _db.Entry(deleted);
                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                returnsData = HardDelete(deleted);
            }
            return returnsData;
        }

        public T Update(T updated)
        {
          T returnsData =  _table.Attach(updated);
            _db.Entry(updated).State = EntityState.Modified;
            _db.SaveChanges();
            return returnsData;
        }

        public T SelectByName(string name)
        {
            return _table.Find(name);
        }
        public T SelectOne(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).FirstOrDefault();
        }

        public List<T> SelectAllWithInclude(Expression<Func<T, bool>> filter, string include, string include2)
        {
            return _table.Where(filter).Include(include).Include(include2).ToList();
        }

        public List<T> SelectAllWithTwoInclude(string include, string include2)
        {
            return _table.Include(include).Include(include2).ToList();
        }

        public List<T> SelectAllWithInclude(Expression<Func<T, bool>> filter, string include)
        {
            return _table.Include(include).ToList();
        }

        public T SelectById(Guid ID)
        {
            return _table.Find(ID);
        }
        public void Detach(T t)
        {
            _db.Entry(t).State = EntityState.Detached;
        }
        public bool MukerrerMi(Expression<Func<T, bool>> predicate) 
        {
            return _table.Any(predicate);
        }
    }
}
