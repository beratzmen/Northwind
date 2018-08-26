using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IProductDal
    {
        List<Products> GetAll();
        Products Get(int productId);
        void Add(Products product);
        void Delete(int productId);
        void Update(Products product);
    }
}
