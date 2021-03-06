﻿using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Dal.Abstract;

namespace Northwind.Bll.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Products product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public Products Get(int productId)
        {
            return _productDal.Get(productId);
        }

        public List<Products> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Products product)
        {
            _productDal.Update(product);
        }
    }
}
