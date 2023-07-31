using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICustomerDal
    {
        List<Customer> ListCustomers();
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
