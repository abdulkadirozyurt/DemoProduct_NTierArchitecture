using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IProductDal
    {
        List<Product> ListProducts();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
