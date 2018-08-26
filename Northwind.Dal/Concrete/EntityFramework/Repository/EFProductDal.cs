using Northwind.Dal.Abstract;
using System;
using System.Collections.Generic;
using Northwind.Entities;
using Northwind.Dal.Concrete.EntityFramework.Context;
using System.Linq;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EFProductDal : IProductDal
    {
        private NorthwindContext context = new NorthwindContext();
        public void Add(Products product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(int productId)
        {
            context.Products.Remove(context.Products.FirstOrDefault(x => x.ProductID == productId));
            context.SaveChanges();
        }

        public Products Get(int productId)
        {
            return context.Products.FirstOrDefault(x => x.ProductID == productId);
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Products product)
        {
            Products productToUpdate = context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            context.SaveChanges();
        }
    }
}
