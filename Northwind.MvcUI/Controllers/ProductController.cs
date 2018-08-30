using Northwind.Entities;
using Northwind.Interfaces;
using Northwind.MvcUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Northwind.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public int PageSize = 5;

        public ViewResult Index(int page = 1)
        {
            List<Products> products = _productService.GetAll();
            //View'a ürünlerin detaylarını gönderiyorum , listelenecek sayfa sayısı,1 sayfadaki ürün sayısı ..
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * PageSize).Take(5).ToList(),

                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrentPage = page
                }
            });
        }
    }
}
