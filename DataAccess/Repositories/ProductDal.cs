using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProductDal : IProductDal
    {
        NTierArchitectureContext context = new NTierArchitectureContext();

        public void Add(Product product)
        {

            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(Product product)
        {
            context.Remove(product);
            context.SaveChanges();
        }

        public List<Product> ListProducts()
        {
            return context.Products.ToList();

        }

        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }


    }
}
