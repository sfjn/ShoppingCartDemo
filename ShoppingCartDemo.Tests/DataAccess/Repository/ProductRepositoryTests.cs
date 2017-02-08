using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCartDemo.DataAccess.Repositories;
using System.Linq;

namespace ShoppingCartDemo.Tests.DataAccess.Repository
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        [Test]
        public void Find_All_Products_Returns_More_Than_Zero()
        {
            var repository = new ProductRepository();
            var products = repository.FindAll();
            Assert.That(products.Any());
        }
    }
}