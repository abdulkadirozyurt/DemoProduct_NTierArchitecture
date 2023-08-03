using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entites.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {

    }
}
