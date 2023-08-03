using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entites.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {



    }
}





// sadece product nesnesine ait metotlar tanımlamamda burası bana yardımcı olacak