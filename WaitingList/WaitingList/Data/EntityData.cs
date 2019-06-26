using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace WaitingList.Data
{
    class EntityData<T> where T: class
    {
        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                return context.Set<T>().Select(selector).ToList();
            }
        }

        public List<T> GetAll()
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                return context.Set<T>().ToList();
            }
        }

        //public int GetCount()
        //{
        //    using (ChinookEntities context = DBContextFactory.Create())
        //    {
        //        return context.Set<T>().Count();
        //    }
        //}

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using(ChinookEntities context = new ChinookEntities())
            {
                return context.Set<T>().Count(predicate);
            }
        }

        public void Insert(T entity)
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges(); // 명령사항 저장하여라
            }
        }

        public void Update(T entity)
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
