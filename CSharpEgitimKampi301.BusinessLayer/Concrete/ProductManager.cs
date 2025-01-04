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
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDAL.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public List<Object> TGetProductsWithCategory()
        {
            return _productDAL.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDAL.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}
