using App.ShoppingCartDemo.Web.ViewModels;
using Microsoft.Owin.Logging;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.ShoppingCartDemo.Web.Controllers
{
    public class CartController : ApiController
    {
        public ILogger Logger { get; set; }
        private CartViewModel cart;
        public CartController()
        {
            cart = new CartViewModel();
        }

        public IEnumerable<ProductItemViewModel> Get()
        {
            return cart.GetAllItems();
        }

        // POST api/<controller>
        public void Post(ProductItemViewModel item)
        {
            cart.AddCartItem(item);
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            cart.RemoveItem(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // DELETE api/<controller>/5
        //public HttpResponseMessage Clear()
        //{
        //cart.RemoveAll();
        //return new HttpResponseMessage(HttpStatusCode.OK);
        //}
    }
}