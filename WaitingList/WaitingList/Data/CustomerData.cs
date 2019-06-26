using System.Collections.Generic;
using System.Linq;

namespace WaitingList.Data
{
    class CustomerData
    {
        internal List<Customer> Search(string name)
        {
            using (ChinookEntities context = DBContextFactory.Create())
            {
                var query = from x in context.Customers select x;

                if (string.IsNullOrEmpty(name) == false)
                    query = query.Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name));

                return query.ToList();
            }
        }
    }
}
