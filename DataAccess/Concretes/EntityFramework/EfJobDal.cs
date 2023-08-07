using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entites.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfJobDal : GenericRepository<Job>, IJobDal
    {

    }
}
