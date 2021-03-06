﻿using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFramework;

namespace Northwind.WcfLibrary.Concrete
{

    public class ProductService : IProductService
    {
        private ProductManager _productManager = new ProductManager(new EFProductDal());
        public void Add(Products product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Products Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Products> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Products product)
        {
            _productManager.Update(product);
        }
    }
}
