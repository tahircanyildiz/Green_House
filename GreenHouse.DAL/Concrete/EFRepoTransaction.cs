using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GreenHouse.DAL.Concrete
{
    public class EFRepoTransaction<T1, T2> where T1 : class where T2 : class
    {

        private readonly DbContext _db1;
        private readonly DbSet<T1> _table1;
        private readonly DbSet<T2> _table2;
        public EFRepoTransaction(Model1 context)
        {
            _db1 = context;
            _table1 = context.Set<T1>();
            _table2 = context.Set<T2>();
        }
        public EFRepoTransaction()
        {
            _db1 = new Model1();
            _table1 = _db1.Set<T1>();
            _table2 = _db1.Set<T2>();
        }

        public List<Tuple<T1, T2>> SelectAll()
        {
            var table1Data = _table1.ToList();
            var table2Data = _table2.ToList();

            var combinedList = table1Data.Zip(table2Data, (item1, item2) => new Tuple<T1, T2>(item1, item2)).ToList();
            return combinedList;
        }

        public void HardDeleteBothTable(T1 deleted, T2 deleted2)
        {
            using (var transaction = new TransactionScope())
            {
                _table1.Attach(deleted);
                _db1.Entry(deleted).State = EntityState.Deleted;

                _table2.Attach(deleted2);
                _db1.Entry(deleted2).State = EntityState.Deleted;

                _db1.SaveChanges();

                transaction.Complete();
            }
        }

        public void SoftDeleteBothTable(T1 deleted, T2 deleted2)
        {
            throw new NotImplementedException();
        }

        public void Update(T1 updated, T2 updated2)
        {
            using (var transaction = new TransactionScope())
            {
                _table1.Attach(updated);
                _table2.Attach(updated2);
                _db1.Entry(updated).State = EntityState.Modified;
                _db1.Entry(updated2).State = EntityState.Modified;
                _db1.SaveChanges();
                transaction.Complete();
            }

        }

        public void AddDouble(T1 add1, T2 add2)
        {
            using (var transaction = new TransactionScope())
            {
                _table1.Add(add1);
                _table2.Add(add2);
                _db1.SaveChanges();
                transaction.Complete();
            }
        }
        public void AddOneToN(T1 add1, params T2[] add2)
        {
            using (var transaction = new TransactionScope())
            {
                _table1.Add(add1);
                foreach (var item in add2)
                {
                    _table2.Add(item);
                }
                _db1.SaveChanges();
                transaction.Complete();
            }
        }

    }
}

