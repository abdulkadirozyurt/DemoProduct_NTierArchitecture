using System.Collections.Generic;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entites.Concretes;

namespace Business.Concretes
{
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }



        public void TAdd(Job entity)
        {
            _jobDal.Add(entity);
        }

        public void TDelete(Job entity)
        {
            _jobDal.Delete(entity);
        }

        public List<Job> TGetAll()
        {
            return _jobDal.GetAll();
        }

        public Job TGetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public void TUpdate(Job entity)
        {
            _jobDal.Update(entity);
        }
    }
}