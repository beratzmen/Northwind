using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Products> GetAll();
        [OperationContract]
        Products Get(int productId);
        [OperationContract]
        void Add(Products product);
        [OperationContract]
        void Delete(int productId);
        [OperationContract]
        void Update(Products product);
    }
}
