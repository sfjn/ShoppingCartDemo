using App.ShoppingCartDemo.Web.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace App.ShoppingCartDemo.Web.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<ProductViewModel> Get()
        {
            return new List<ProductViewModel>() { };
        }
    }
}