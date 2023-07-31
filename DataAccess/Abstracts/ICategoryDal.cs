using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> ListCategories();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
