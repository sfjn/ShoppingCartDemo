using System.Collections.Generic;

namespace App.ShoppingCartDemo.Web.ViewModels
{
    internal class CartViewModel
    {
        IList<CartItemViewModel> _items = new List<CartItemViewModel>()
        {
            new CartItemViewModel() { Name = "Foobar 1" },
            new CartItemViewModel() { Name = "Foobar 2" },
            new CartItemViewModel() { Name = "Foobar 3" },
        };
        public IEnumerable<CartItemViewModel> GetAllItems()
        {
            return _items;
        }

        public void AddCartItemViewModel(CartItemViewModel item)
        {
            _items.Add(item);
        }

        public void RemoveItem(CartItemViewModel item)
        {
            _items.RemoveAt(_items.IndexOf(item));
        }
    }
}