using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGenericService<T>
    {
        List<T> TGetAll();
        T TGetById(int id);


        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);

    }
}
