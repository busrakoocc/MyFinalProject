﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //genereic constraint = generic kısıtlama
    //class = referans tip
    //IEntity = IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() = new'lenebilir olmalı     (normalde IEntity new'lenmez)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
    }
}
