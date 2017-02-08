using App.ShoppingCartDemo.Web.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace App.ShoppingCartDemo.Web.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<ProductViewModel> Get()
        {
            return new List<ProductViewModel>()
            {
                    new ProductViewModel() { Brand = "Foobar", Id = 1, Name = "Lorem Ipsum Item", InStock = true, Description = "Description", Price = 1000},
                    new ProductViewModel() { Brand = "Foobar", Id = 2, Name = "Lorem Ipsum Item", InStock = false, Description = "Description", Price = 1000},
                    new ProductViewModel() { Brand = "Foobar", Id = 3, Name = "Lorem Ipsum Item", Description = "Description", InStock = true, Price = 1000},
                    new ProductViewModel() { Brand = "Foobar", Id = 4, Name = "Lorem Ipsum Item", Description = "Description", InStock = false, Price = 1000},
            };
        }
    }
}