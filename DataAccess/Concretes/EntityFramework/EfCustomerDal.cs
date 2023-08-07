using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entites.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetCustomersWithJob()
        {
            using (var context = new NTierArchitectureContext())
            {
                return context.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}





