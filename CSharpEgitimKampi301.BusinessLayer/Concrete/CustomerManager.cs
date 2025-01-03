using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public void TDelete(Customer entity)
        {
            _customerDAL.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDAL.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName!="" && entity.CustomerName.Length>=3 && entity.CustomerCity!=null && entity.CustomerSurname!="" && entity.CustomerName.Length <= 30)
            {
                _customerDAL.Insert(entity);
            }
            else
            {
                // Hata mesajı ver
            }
        }

        public void TUpdate(Customer entity)
        {
            if(entity.CustomerId!=0 && entity.CustomerCity.Length >= 3)
            {
                _customerDAL.Update(entity);
            }
            else
            {
                // Hata mesajı
            }
        }
    }
}
