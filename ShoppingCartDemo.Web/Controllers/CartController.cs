﻿using System.Collections.Generic;
using System.Web.Http;

namespace ShoppingCartDemo.Web.Controllers
{
    public class CartController : ApiController
    {
        public IEnumerable<CartItem> GetItems()
        {
            return new List<CartItem>() { };
        }
    }

    public class CartItem { }
}
