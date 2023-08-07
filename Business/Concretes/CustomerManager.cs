using System.Collections.Generic;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entites.Concretes;

namespace Business.Concretes
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        } 

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TAdd(Customer entity)
        {
            _customerDal.Add(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }

        public List<Customer> GetCustomersWithJob()
        {
           return _customerDal.GetCustomersWithJob();
        }
    }
}