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
            cart.RemoveItem(null);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }

    internal class ShoppingCart
    {
        IList<CartItem> _items = new List<CartItem>()
        {
                new CartItem() { Name = "Foobar 1" },
                new CartItem() { Name = "Foobar 2" },
                new CartItem() { Name = "Foobar 3" },
        };
        public IEnumerable<CartItem> GetAllItems()
        {
            return _items;
        }

        public void AddCartItem(CartItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(CartItem item)
        {
            _items.Remove(item);
        }
    }

    public class CartItem
    {
        public string Name { get; set; }
    }
}
