using Business.Abstracts;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            if (entity.Name.Length >= 5 && entity.UnitPrice >= 1 && entity.Name != null)
            {
                _productDal.Add(entity);
            }
            else
            {
                //hata mesajları 
            }



        }

        public void TDelete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
