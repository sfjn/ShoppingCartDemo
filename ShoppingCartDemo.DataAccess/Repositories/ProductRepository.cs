using ShoppingCartDemo.DataAccess.DTO;
using System.Collections.Generic;

namespace ShoppingCartDemo.DataAccess.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<ProductDTO> FindAll()
        {
            //using (var db = DbConnection.Get())
            //{
            //return db.Query<ProductDTO>("SELECT * FROM Products");
            //}
            return new List<ProductDTO>()
            {
                new ProductDTO() { Brand = "Foobar", Id = 1, Name = "Lorem Ipsum Item", InStock = 1, Description = "Description", Price = 1000},
                new ProductDTO() { Brand = "Foobar", Id = 2, Name = "Lorem Ipsum Item", InStock = 1, Description = "Description", Price = 1000},
                new ProductDTO() { Brand = "Foobar", Id = 3, Name = "Lorem Ipsum Item", Description = "Description", InStock = 1, Price = 1000},
                new ProductDTO() { Brand = "Foobar", Id = 4, Name = "Lorem Ipsum Item", Description = "Description", InStock = 1, Price = 1000},
            };
        }

    }
}
