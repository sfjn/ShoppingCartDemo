using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App.ShoppingCartDemo.Web.ViewModels;
using Microsoft.Owin.Logging;

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

        public IEnumerable<CartItemViewModel> Get()
        {
            return cart.GetAllItems();
        }

        // POST api/<controller>
        public void Post(CartItemViewModel item)
        {
            cart.AddCartItem(item);
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            cart.RemoveItem(null);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}