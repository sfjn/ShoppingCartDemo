using System;
using System.Web.Mvc;

namespace App.ShoppingCartDemo.Web.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
