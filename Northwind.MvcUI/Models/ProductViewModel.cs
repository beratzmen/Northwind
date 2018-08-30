using System.Collections.Generic;
using Northwind.Entities;

namespace Northwind.MvcUI.Models
{
    public class ProductViewModel
    {
        public PagingInfo PagingInfo { get; internal set; }
        public List<Products> Products { get; set; }
    }
}