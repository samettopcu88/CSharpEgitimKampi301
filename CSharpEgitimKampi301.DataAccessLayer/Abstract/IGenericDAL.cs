﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
