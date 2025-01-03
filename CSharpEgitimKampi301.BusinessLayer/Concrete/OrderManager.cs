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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDAL _orderDAL;

        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }

        public void TDelete(Order entity)
        {
            _orderDAL.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderDAL.GetAll();
        }

        public Order TGetById(int id)
        {
            return _orderDAL.GetById(id);
        }

        public void TInsert(Order entity)
        {
            _orderDAL.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDAL.Update(entity);
        }
    }
}
