using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.ShoppingCartDemo.Web.Controllers
{
    public class CartController : ApiController
    {
        ShoppingCart cart;
        public CartController()
        {
            cart = new ShoppingCart();
        }
        public IEnumerable<CartItem> GetItems()
        {
            return new List<CartItem>() { };
        }
        public IEnumerable<CartItem> Get()
        {
            return cart.GetAllItems();
        }

        // POST api/<controller>
        public void Post(CartItem item)
        {
            cart.AddCartItem(item);
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            cart.RemoveItem(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }

    internal class ShoppingCart
    {
        public IEnumerable<CartItem> GetAllItems()
        {
            throw new System.NotImplementedException();
        }

        public void AddCartItem(CartItem item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveItem(int id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CartItem { }
}
