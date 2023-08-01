using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {



    }
}





// sadece product nesnesine ait metotlar tanımlamamda burası bana yardımcı olacak