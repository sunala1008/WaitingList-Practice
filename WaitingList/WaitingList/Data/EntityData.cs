using System;
using System.Collections.Generic;
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

        public int GetCount()
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                return context.Set<T>().Count();
            }
        }
    }
}
