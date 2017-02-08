using System.Collections.Generic;
using System.Linq;

namespace App.ShoppingCartDemo.Web.ViewModels
{
    internal class CartViewModel
    {
        public CartViewModel()
        {
            if (_items == null)
                _items = new List<ProductItemViewModel>();
        }
        private static IList<ProductItemViewModel> _items;
        public IEnumerable<ProductItemViewModel> GetAllItems()
        {
            return _items;
        }

        public void AddCartItem(ProductItemViewModel item)
        {
            _items.Add(item);
        }

        public void RemoveItem(int id)
        {
            _items.Remove(_items.Where(x => x.Id == id).First());
        }

        public void RemoveAll()
        {
            _items.Clear();
        }
    }
}